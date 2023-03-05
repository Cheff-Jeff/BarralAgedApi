namespace BarrelAgedApi.Models
{
    public class FingerSignIn
    {
        public byte[] Signature { get; set; }
        public byte[] PublicKey { get; set; }

        public FingerSignIn(FingerSignDto dto)
        {
            if (dto.signature != null)
            { 
                Signature = Convert.FromBase64String(dto.signature);
            }
            if (dto.publicKey != null)
            { 
                PublicKey = Convert.FromBase64String(dto.publicKey);
            }
        }
    }
}
