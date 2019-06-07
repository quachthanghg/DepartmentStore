using DepartmentStore.Data.Enums;
using DepartmentStore.Data.Interface;
using DepartmentStore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DepartmentStore.Data.Entities
{
    [Table("Orders")]
    public class Order : DomainEntity<long>, ISwitchable, IDateTracking
    {
        public Order() { }

        public Order(string customerName, string customerAddress, string customerMobile, string customerMessage,
            OrderStatus billStatus, PaymentMethod paymentMethod, Status status, string customerId)
        {
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerMobile = customerMobile;
            CustomerMessage = customerMessage;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }

        public Order(int id, string customerName, string customerAddress, string customerMobile, string customerMessage,
           OrderStatus billStatus, PaymentMethod paymentMethod, Status status, string customerId)
        {
            Id = id;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerMobile = customerMobile;
            CustomerMessage = customerMessage;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }
        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        public PaymentMethod PaymentMethod { set; get; }

        public OrderStatus BillStatus { set; get; }

        public DateTime CreateDate { set; get; }
        public DateTime? ModifiedDate { set; get; }

        [DefaultValue(Status.Active)]
        public Status Status { set; get; } = Status.Active;

        [StringLength(450)]
        public string CustomerId { set; get; }

        [ForeignKey("CustomerId")]
        public virtual AppUser User { set; get; }

        public virtual ICollection<OrderDetail> BillDetails { set; get; }
    }
}
