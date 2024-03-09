namespace DVCP.Migrations
{
    using DVCP.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DVCP.Models.DVCPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DVCPContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.WebInfo.AddOrUpdate( x =>x.id,
                new WebInfo
                {
                    id = 1,
                    web_name = "The News Time",
                    web_des = "Trang WEB chính thức về bài báo 24h -the News Time",
                    web_about = "Về The News Time",
                }
                );
            context.Users.AddOrUpdate(x => x.username,
                new User
                {
                    username = "admin",
                    password = "0192023A7BBD73250516F069DF18B500", // = admin123
                    fullname = "ADMIN 24H",
                    userrole = "admin",
                    status = true,
                }
                );
            context.Tags.AddOrUpdate(x => x.TagID,
                new Tag { TagID = 1, TagName = "Dân Sinh" },
                new Tag { TagID = 2, TagName = "Chất Liệu" },
                new Tag { TagID = 3, TagName = "Phân Tích" },
                new Tag { TagID = 4, TagName = "Quân Sự" },
                new Tag { TagID = 5, TagName = "Phát Minh" },
                new Tag { TagID = 6, TagName = "Văn Hóa" },
                new Tag { TagID = 7, TagName = "Phong Tục" },
                new Tag { TagID = 8, TagName = "Tôn giáo" },
                new Tag { TagID = 9, TagName = "Trang Phục" },
                new Tag { TagID = 10, TagName = "Thị trường" },
                new Tag { TagID = 11, TagName = "Diễn Đàn" },
                new Tag { TagID = 12, TagName = "Ẩm thực" },
                new Tag { TagID = 13, TagName = "Điểm đến" },
                new Tag { TagID = 14, TagName = "Tư Vấn" },
                new Tag { TagID = 15, TagName = "Du học " },
                new Tag { TagID = 16, TagName = "Dự Án" },
                new Tag { TagID = 17, TagName = "Doanh nghiệp" },
                new Tag { TagID = 18, TagName = "Thiên Nhiên" },
                new Tag { TagID = 19, TagName = "Thời Tiết" },
                new Tag { TagID = 20, TagName = "Y Tế" }
                
                );
            context.SaveChanges();
        }
    }
}
