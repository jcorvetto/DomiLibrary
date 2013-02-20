﻿namespace DomiLibrary.Utility.Dns.Bind
{
    public class ConstantesDnsBind
    {
        public const string NumSerie = "serial number";
        public const string TiempoActualizacion = "refresh";
        public const string TiempoReintento = "retry";
        public const string TiempoCaducidad = "expire";
        public const string TiempoVida = "ttl";

        public const string Ns = "\tNS\t";
        public const string Mx = "\tMX\t";
        public const string A = "\tA\t";
        public const string Aaa = "\tAAA\t";
        public const string Cname = "\tCNAME\t";
        public const string Ptr = "\tPTR\t";
        public const string Spf = "\tSPF\t";

        public const string NsNormalizado = "NS";
        public const string MxNormalizado = "MX";
        public const string ANormalizado = "A";
        public const string AaaNormalizado = "AAA";
        public const string CnameNormalizado = "CNAME";
        public const string PtrNormalizado = "PTR";
        public const string SpfNormalizado = "SPF";
    }
}
