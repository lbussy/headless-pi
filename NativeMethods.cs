using System;
using System.Threading;
using System.Runtime.InteropServices;

namespace Headless_Pi
{
    class NativeMethods
    {
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern IntPtr CreateFile(
            string lpFileName,
            uint dwDesiredAccess,
            uint dwShareMode,
            IntPtr SecurityAttributes,
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes,
            IntPtr hTemplateFile
        );

        [DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool DeviceIoControl(
            IntPtr hDevice,
            uint dwIoControlCode,
            IntPtr lpInBuffer,
            uint nInBufferSize,
            IntPtr lpOutBuffer,
            uint nOutBufferSize,
            out uint lpBytesReturned,
            IntPtr lpOverlapped
        );

        [DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool DeviceIoControl(
            IntPtr hDevice,
            uint dwIoControlCode,
            byte[] lpInBuffer,
            uint nInBufferSize,
            IntPtr lpOutBuffer,
            uint nOutBufferSize,
            out uint lpBytesReturned,
            IntPtr lpOverlapped
        );

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]

        private static extern bool CloseHandle(IntPtr hObject);
        private IntPtr handle = IntPtr.Zero;

        const uint GENERIC_READ = 0x80000000;
        const uint GENERIC_WRITE = 0x40000000;
        const int FILE_SHARE_READ = 0x1;
        const int FILE_SHARE_WRITE = 0x2;
        const int FSCTL_LOCK_VOLUME = 0x00090018;
        const int FSCTL_DISMOUNT_VOLUME = 0x00090020;
        const int IOCTL_STORAGE_EJECT_MEDIA = 0x2D4808;
        const int IOCTL_STORAGE_MEDIA_REMOVAL = 0x002D4804;

        /// <summary>
        /// Constructor for the USBEject class
        /// </summary>
        /// <param name="driveLetter">This should be the drive letter. Format: F:, C:..</param>
        /// <returns>Handle to USB drive</returns>
        public static IntPtr USBEject(string driveLetter)
        {
            string filename = @"\\.\" + driveLetter[0] + ":";
            return CreateFile(filename, GENERIC_READ |
                GENERIC_WRITE, FILE_SHARE_READ |
                FILE_SHARE_WRITE,
                IntPtr.Zero, 0x3, 0, IntPtr.Zero);
        }

        /// <summary>
        /// Eject a USB device based on the handle retuned from USBEject("X:")
        /// </summary>
        /// <param name="handle">Handle to USB drive from USBEject</param>
        /// <returns>Success/Failure</returns>
        public bool Eject(IntPtr handle)
        {
            bool result = false;

            if (LockVolume(handle) && DismountVolume(handle))
            {
                PreventRemovalOfVolume(handle, false);
                result = AutoEjectVolume(handle);
            }
            CloseHandle(handle);
            return result;
        }

        /// <summary>
        /// Determines if we are able to lock a volume
        /// </summary>
        /// <param name="handle">Handle to USB drive from USBEject</param>
        /// <returns>Success/failure</returns>
        private bool LockVolume(IntPtr handle)
        {
            uint byteReturned;

            for (int i = 0; i < 10; i++)
            {
                if (DeviceIoControl(handle, FSCTL_LOCK_VOLUME, IntPtr.Zero, 0,
                    IntPtr.Zero, 0, out byteReturned, IntPtr.Zero))
                {
                    return true;
                }
                Thread.Sleep(500);
            }
            return false;
        }

        /// <summary>
        /// Adds/removes volume protecton
        /// </summary>
        /// <param name="handle">Handle to USB drive from USBEject</param>
        /// <param name="prevent">True or false</param>
        /// <returns>Success/failure</returns>
        private bool PreventRemovalOfVolume(IntPtr handle, bool prevent)
        {
            byte[] buf = new byte[1];
            uint retVal;

            buf[0] = (prevent) ? (byte)1 : (byte)0;
            return DeviceIoControl(handle, IOCTL_STORAGE_MEDIA_REMOVAL,
                buf, 1, IntPtr.Zero, 0, out retVal, IntPtr.Zero);
        }

        /// <summary>
        /// Dismounts USB volume to allow eject
        /// </summary>
        /// <param name="handle">Handle to USB drive from USBEject</param>
        /// <returns>Success/Failure</returns>
        private bool DismountVolume(IntPtr handle)
        {
            uint byteReturned;
            return DeviceIoControl(handle, FSCTL_DISMOUNT_VOLUME,
                IntPtr.Zero, 0, IntPtr.Zero, 0, out byteReturned, IntPtr.Zero);
        }

        /// <summary>
        /// Handles ejecting USB device
        /// </summary>
        /// <param name="handle">Handle to USB drive from USBEject</param>
        /// <returns>Success/failure</returns>
        private bool AutoEjectVolume(IntPtr handle)
        {
            uint byteReturned;
            return DeviceIoControl(handle, IOCTL_STORAGE_EJECT_MEDIA,
                IntPtr.Zero, 0, IntPtr.Zero, 0, out byteReturned, IntPtr.Zero);
        }

        /// <summary>
        /// Closes handle to device from USBEject
        /// </summary>
        /// <param name="handle">Handle to USB drive from USBEject</param>
        /// <returns>Success/failure</returns>
        private bool CloseVolume(IntPtr handle)
        {
            return CloseHandle(handle);
        }
    }
}
