//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trukov_315_exam.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductProdaja
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int ClientID { get; set; }
        public int WorkerID { get; set; }
        public System.DateTime Date { get; set; }
        public double Cost { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Product Product { get; set; }
        public virtual Worker Worker { get; set; }
    }
}