using System;
using System.Collections.Generic;
using System.Text;

namespace OpenGame
{
    public static class GEC
    {
        ///100+
        public const int Continue = 10000000;
        public const int SwitchingProtocols = 10100000;

        ///200+
        public const int Success = 20000000;
        public const int Created = 20100000;
        public const int Accepted = 20200000;
        public const int NonAuthoritativeInformation = 20300000;
        public const int NoContent = 20400000;


        ///400+
        public const int BadRequest = 40000000;
        public const int Unauthorized = 40100000;
        public const int PaymentRequired = 40200000;
        public const int Forbidden = 40300000;
        public const int NotFound = 40400000;
        public const int MethodNotAllowd = 40500000;
        public const int NotAcceptable = 40600000;
        public const int ProxyAuthenticationRequired = 40700000;
        public const int ReqeustTimeout = 40800000;
        public const int Conflict = 40900000;


        ///500+
        public const int InternalServerError = 50000000;
    }
}
