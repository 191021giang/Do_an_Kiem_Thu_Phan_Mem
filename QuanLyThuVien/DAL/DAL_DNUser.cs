using DTO;
namespace DAL
{
    public class DAL_DNUser:DNU
    {
        public string CheckUser(DTO_Users dto_user)
        {
            string us = CheckDTO(dto_user);
            return us;
        }
    }
}
