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
    
    public partial class MonthlyPayment
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int WorkerID { get; set; }
        public double PaySum { get; set; }
        public System.DateTime LastPayDate { get; set; }
        public System.DateTime RealPayDate { get; set; }
        public string Status { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
