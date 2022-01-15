using DTO;
namespace DAL
{
    public class DAL_DNAdmin : DNA
    {       
        public string CheckAdmin(DTO_Admin dto_admin)
        {
            string ad = Checkdto(dto_admin);
            return ad;
        }       
    }
}
