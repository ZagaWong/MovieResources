//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieResources.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Step_Movie_Country
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> Movie { get; set; }
        public string Country { get; set; }
    
        public virtual Basic_Movie Basic_Movie { get; set; }
    }
}
