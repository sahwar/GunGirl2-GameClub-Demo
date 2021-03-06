//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameClub.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            this.FillOut = new HashSet<FillOut>();
            this.Select = new HashSet<Select>();
        }

        [Display(Name = "问题ID")]
        public string QuestionID { get; set; }
        [Display(Name = "问卷ID")]
        public string QuestionaryID { get; set; }
        [Display(Name = "类型")]
        public bool Type { get; set; }
        [Display(Name = "问题内容")]
        public string QuestionContext { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FillOut> FillOut { get; set; }
        public virtual Questionary Questionary { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Select> Select { get; set; }
    }
}
