//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\lsasrv.dll
// Interface ID: 3dde7c30-165d-11d1-ab8f-00805f14db40
// Interface Version: 1.0



namespace rpc_3dde7c30_165d_11d1_ab8f_00805f14db40_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_1(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public byte[] Read_0()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_1()
        {
            return ReadConformantArray<byte>();
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("3dde7c30-165d-11d1-ab8f-00805f14db40", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int s_BackuprKey(System.Guid p0, byte[] p1, int p2, out byte[] p3, out int p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.Write_0(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p2);
            m.WriteInt32(p2);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(0, m);
            p3 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_1), false);
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}
