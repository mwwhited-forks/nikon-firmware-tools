namespace Nikon_Patch
{
    class D3400_0112 : Firmware
    {
        public D3400_0112()
        {
            p = new Package(0x20);
            Model = "D3400";
            Version = "1.12";
        }
    }

    //0x28, 0xC8, 0xDB, 0x35, 0x83, 0xC1, 0x9A, 0x6A, 0x26, 0xEC, 0x21, 0xB4, 0x7D, 0x6D, 0x4E, 0xC5, 

    class D3400_0113 : Firmware
    {
        Patch[] patch_liveview_no_timeout_15m =
{
               new Patch(1,0x311460, new byte[]{0xA0, 0xBB, 0x0D, 0x00}, new byte[] {0x80, 0x27, 0xCB, 0x05} )
        };


        public D3400_0113()
        {
            p = new Package(0x20);
            
            Model = "D3400";
            Version = "1.13";

            Patches.Add(new PatchSet(PatchLevel.Alpha, "Liveview (15min) No Timeout", patch_liveview_no_timeout_15m));
        }
    }
}
