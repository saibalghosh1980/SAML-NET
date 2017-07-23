using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// AccountSettings
/// 
/// Replace this class with an interface to your own applications account settings. 
/// 
/// Each account should as a minimum have the following:
///  - A URL pointing to the identity provider for sending Auth Requests
///  - A X.509 certificate for validating the SAML Responses from the identity provider
/// 
/// These should be retrieved from the account store/database on each request in the authentication flow.
/// </summary>
public class AccountSettings
{
    public string certificate = "-----BEGIN CERTIFICATE-----\nMIIEbDCCA1SgAwIBAgIBATANBgkqhkiG9w0BAQsFADB5MSAwHgYDVQQKDBdBWEEgVGVjaG5vbG9neSBTZXJ2aWNlczEYMBYGA1UECwwPQVBEQyBTaXRlTWluZGVyMRYwFAYDVQQDDA1GZWRlcmF0aW9uIENBMSMwIQYJKoZIhvcNAQkBFhRJQU0uQ09FQGF4YS10ZWNoLmNvbTAeGA0yMDE2MTIwMTAwMDBaGA0yMDI2MDEwMTAwMDBaMHoxIDAeBgNVBAoMF0FYQSBUZWNobm9sb2d5IFNlcnZpY2VzMRgwFgYDVQQLDA9BUERDIFNpdGVNaW5kZXIxFzAVBgNVBAMMDmZlZGVyYXRpb24tZGV2MSMwIQYJKoZIhvcNAQkBFhRJQU0uQ09FQGF4YS10ZWNoLmNvbTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAKGsG32KF/upe3jU6AK4vnAP3rTmHhTwSrDLRKazkPQ8jr26aZQauuURbquApFruyfDtNw4dQOr8hZWEzcLVp77Ux2Nhl+4lkVMXNVvUKG/DrUO34rzpEvxcev2QEm4xxJtOnKf8uyVEXU4sp4keuFO4gCCRwtzOtnWLJX1Kx+Xrhxw84maVHl+6ft2TZfOOmLB7vTr9us/h9CaiBexogrRczlKcHMwgOmYE8klXSDQpiC0eoLnsfwuaNmB9F4zvfdD8EkbN2X6z2FN6LdJoKw3fJkzMgVkUUwyg1lnxwSexTiVM7HXIGB+FMJ1RdBtQfucknYK4Rczobl2zPCKiUOkCAwEAAaOB/TCB+jAJBgNVHRMEAjAAMB0GA1UdDgQWBBQTQg8mJzTE5rKv5URDmK2Ctu/i+zCBqwYDVR0jBIGjMIGggBTI3gZBuBqDzVBewAT5xSAb19XyVKF9pHsweTEgMB4GA1UECgwXQVhBIFRlY2hub2xvZ3kgU2VydmljZXMxGDAWBgNVBAsMD0FQREMgU2l0ZU1pbmRlcjEWMBQGA1UEAwwNRmVkZXJhdGlvbiBDQTEjMCEGCSqGSIb3DQEJARYUSUFNLkNPRUBheGEtdGVjaC5jb22CCQDCQlR8PZam6DATBgNVHSUEDDAKBggrBgEFBQcDATALBgNVHQ8EBAMCBaAwDQYJKoZIhvcNAQELBQADggEBADHCxuwBiS3w3UuV5Y1ZLAiCURgTlPFc3eZ6Qe403f8/PsRYOfCDWLW5smneHT9SRJrM7m0DMxmKF1bndrYC21THz+sAutt3wIwJh6k+KqPcYuP6H3mHokqBy93We7Ux6dYtFvCHETProGRs3kDBeC0NFDHDOl3STes50RC29rebs/CPTIVd7Q/43UzRUDUXaFPxC7SCfXJTy1ZVN1mFTPAAJ6hqb/v7FQd4bNitGaPS27obRGVIEDYV9mO1akUTo6qVt5+wcuktGQycime5afC5Y/ONV90xLoeAYAwSf12vFiE9ZMRL98eb0ESpNGTi8fu/U/X4Z4+cIiA2EvkSilU=\n-----END CERTIFICATE-----";
    public string idp_sso_target_url = "https://preprodapfedsso.axa-tech.com/affwebservices/public/saml2sso";
}
