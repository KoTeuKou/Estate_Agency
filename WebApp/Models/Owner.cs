using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class OwnerVm
    {
        public OwnerVm(){}

        public OwnerVm(int idOwner, string ownerName)
        {
            IdOwner = idOwner;
            OwnerName = ownerName;
        }

        public int IdOwner { get; set; }
        public string OwnerName { get; set; }
    }
}