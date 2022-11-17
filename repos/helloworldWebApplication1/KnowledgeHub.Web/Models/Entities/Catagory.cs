using System.ComponentModel.DataAnnotations; //add this to provide authentication like:- required and max length to the function
                 
namespace KnowledgeHub.Web.Models.Entities
{
    public class Catagory
    {
        public int CatagoryID { get; set; }
        [Required(ErrorMessage ="* Please Enter The Name") ]
        [MaxLength(50)]
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
