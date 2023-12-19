﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccordionMaui.Model;

namespace AccordionMaui.ViewModel
{
    public class ItemInfoRepository
    {
        public ObservableCollection<ItemInfo> Info { get; set; }

        public ItemInfoRepository()
        {
            Info = new ObservableCollection<ItemInfo>();
            ExpandCollapse = new Command<object>(OnExpandCollapse);
            Info.Add(new ItemInfo() { Name = "Cheese burger", Description = "Hamburger accompanied with melted cheese. The term itself is a portmanteau of the words cheese and hamburger. The cheese is usually sliced, then added a short time before the hamburger finishes cooking to allow it to melt." });
            Info.Add(new ItemInfo() { Name = "Veggie burger", Description = "Veggie burger, garden burger, or tofu burger uses a meat analogue, a meat substitute such as tofu, textured vegetable protein, seitan (wheat gluten), Quorn, beans, grains or an assortment of vegetables, which are ground up and formed into patties." });
            Info.Add(new ItemInfo() { Name = "Barbecue burger", Description = "Prepared with ground beef, mixed with onions and barbecue sauce, and then grilled. Once the meat has been turned once, barbecue sauce is spread on top and grilled until the sauce caramelizes." });
            Info.Add(new ItemInfo() { Name = "Chili burger", Description = "Consists of a hamburger, with the patty topped with chili con carne." });
        }

        public Command<object> ExpandCollapse { get; set; }

        private void OnExpandCollapse(object obj)
        {
            var item = (obj as Button)!.BindingContext as ItemInfo;
            item!.IsExpand = !item.IsExpand;
        }
    }
}
