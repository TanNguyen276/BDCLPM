﻿using DVCP.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DVCP.ViewModel
{
    public class RequiredSelectListItem : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var list = value as List<SelectListItem>;
            if (list != null)
            {
                return list.Where(x => x.Selected == true).Count() > 0;
            }
            return false;
        }
    }
    public enum PostType : int
    {
        [Display(Name = "Bài Viết Bình Thường")]
        Normal = 1, // Bình thường
        [Display(Name = "Slide Hình Ảnh")]
        Slide = 2, // Slide ảnh
        [Display(Name = "Tranh Cãi, Thảo Luận")]
        Discuss = 3, // Tranh cãi, thảo luận
    }
    public enum Rated : int
    {
        [Display(Name = "Bài Viết Bình Thường")]
        Normal = 3,
        [Display(Name = "Đề Xuất Cao")]
        HighRated = 2,
        [Display(Name = "Đề Xuất Quan Trọng")]
        HighestRated = 1,
    }
    public enum Dynasty
    {
        //0
        [Display(Name = "Tin Tức Chính")]
        TinChinh = 0,
        //1.. etc
        [Display(Name = "Thời Sự")]
        ThoiSu = 1,
        [Display(Name = "Thế Giới")]
        TheGioi = 2,
        [Display(Name = "Pháp Luật")]
        PhapLuat = 3,
        [Display(Name = "Công Nghệ")]
        CongNghe = 4,
        [Display(Name = "Giáo Dục")]
        GiaoDuc = 5,
        [Display(Name = "Du Lịch")]
        DuLich = 6,
        [Display(Name = "Văn Hóa")]
        VanHoa = 7,
        [Display(Name = "Giải Trí")]
        GiaiTri = 8,
        [Display(Name = "Thể Thao")]
        TheThao = 9,
        [Display(Name = "Sức Khỏe")]
        SucKhoe = 10,
        [Display(Name = "Giáo dục")]
        giaoduc =11

    }
   
    
    public class newPostViewModel
    {

        [RequiredSelectListItem(ErrorMessage = "Vui lòng chọn ít nhất 1 thể loại")]
        public List<SelectListItem> post_tag { get; set; }
        public int post_id { get; set; }

        public int? userid { get; set; }

        
        [StringLength(200)]
        [MinLength(10,ErrorMessage = "Ít nhất 10 ký tự")]
        [Required(ErrorMessage = "Vui lòng nhập tiêu đề !")]
        public string post_title { get; set; }

        //[Required(ErrorMessage = "Vui lòng nhập teaser ngắn !")]
        [StringLength(500)]
        public string post_teaser { get; set; }

        [StringLength(200)]
        public string AvatarImage { get; set; }
        [StringLength(500)]
        public string post_review { get; set; }

        [AllowHtml]
        [Required(ErrorMessage = "Hãy nhập nội dung cho bài báo")]
        public string post_content { get; set; }

        [Range(1, 3, ErrorMessage = "Vui lòng chọn đúng kiểu bài báo!")]
        [Required(ErrorMessage ="Vui lòng chọn kiểu bài báo!")]
        public PostType post_type { get; set; }


        [StringLength(200)]
        public string meta_tag { get; set; }

        public DateTime? create_date { get; set; }

        public DateTime? edit_date { get; set; }

        public string imagepath { get; set; }

        public bool changeAvatar { get; set; } = false;

        [DataType(DataType.Upload)]
        public HttpPostedFileBase avatarFile { get; set; }

        public Dynasty dynasty { get; set; }

        public Rated Rated { get; set; } = Rated.Normal;

        public bool Status { get; set; }
        public bool UpdateSlug { get; set; } = false;
    }
}