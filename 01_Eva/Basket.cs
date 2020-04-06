using System.Collections.Generic;

namespace _01_Eva.Model
{
    class Basket
    {
        public List<Category> Categories { get; set; } = new List<Category>()
        {
            new Category
            {
                Name = "Жилое помещение",
                Items = new List<object>(new List<dwelling>()
                {
                    new dwelling {Name = "Квартира"}
                })

            },
            new Category
            {
                Name = "Нежилое помещение",
                Items = new List<object>(new List<nonpremise>()
                {
                    new nonpremise {Name = "Офисно-торговый объект свободного назначения"},
                    new nonpremise {Name = "Офисы класса А, В"},
                    new nonpremise {Name = "Торговая недвижимость"},
                    new nonpremise {Name = "Производственно-складская недвижимость"}
                })

            },
            new Category
            {
                Name = "Здание",
                Items = new List<object>(new List<building>()
                {
                    new building {Name = "Жилой дом"},
                    new building {Name = "Офисно-торговый объект свободного назначения"},
                    new building {Name = "Офисы класса А, В"},
                    new building {Name = "Торговая недвижимость"},
                    new building {Name = "Производственно-складская недвижимость"}
                })

            },
            new Category
            {
                Name = "Здание с земельным участком",
                Items = new List<object>(new List<building_plot>()
                {
                    new building_plot {Name = "Жилой дом"},
                    new building_plot {Name = "Офисно-торговый объект свободного назначения"},
                    new building_plot {Name = "Офисы класса А, В"},
                    new building_plot {Name = "Торговая недвижимость"},
                    new building_plot {Name = "Производственно-складская недвижимость"}
                })

            },
            new Category
            {
                Name = "Земельный участок",
                Items = new List<object>(new List<land_plot>()
                {
                    new land_plot {Name = "Под индустриальную застройку"},
                    new land_plot {Name = "Под офисно-торговую застройку"},
                    new land_plot {Name = "Под многоквартирную жилую застройку"},
                    new land_plot {Name = "Под объекты рекреации"},
                    new land_plot {Name = "Под объекты придорожного сервиса"}
                })

            },
        };
    }
}
