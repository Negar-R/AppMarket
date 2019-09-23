using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping.Alterations;
using FluentNHibernate.Automapping;
using Market.Entities;

namespace Market.Data
{
    //public class OrderMap : IAutoMappingOverride<Order>
    //{
    //    public void Override(AutoMapping<Order> mapping)
    //    {
    //        mapping.Id(x => x.Id);
    //        mapping.Map(x => x.Code);
    //        mapping.Map(x => x.CreationDate);
    //        mapping.Map(x => x.Title);
    //        mapping.HasMany(x => x.OrderItem).Cascade.All();
    //    }
    //}
}
