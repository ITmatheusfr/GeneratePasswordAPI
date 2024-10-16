namespace GeneratePasswordAPI.Models
{
    public class PasswordRequestModel
    {
        public int Length { get; set; }
        public int QtySymbols { get; set; }
        public int QtyNumbers { get; set; }
        public int QtyUppercaseChars { get; set; }
    }

}
