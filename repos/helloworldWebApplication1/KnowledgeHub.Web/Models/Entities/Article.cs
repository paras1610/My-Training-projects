using System.ComponentModel.DataAnnotations;

namespace KnowledgeHub.Web.Models.Entities
{
    public class Article
    {
        public int ArticleID { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [Url]
        [Display(Name ="Article URL")]
        public string ArticleURL { get; set; }
        
        
        public string  Description { get; set; }
        
        public Catagory Catagory { get; set; }

        [Display(Name ="Select catagory")]
        public int CatagoryID { get; set; }
        
        public string PostedBy { get; set; }
        
        public bool IsApproved { get; set; }
                
        
        public DateTime DateSubmitted { get; set; }
    }
    
}
