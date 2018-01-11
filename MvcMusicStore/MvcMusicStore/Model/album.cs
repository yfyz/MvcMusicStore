using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Maticsoft.Model
{
	/// <summary>
	/// album:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class album
	{
		public album()
		{}
		#region Model
		private int _albumid;
		private int _genreid;
		private int _artistid;
		private string _title;
		private decimal _price;
		private string _albumarturl;
		/// <summary>
		/// 
		/// </summary>
        /// 
        [Key]
       // [ScaffoldColumn(false)]
		public int AlbumId
		{
			set{ _albumid=value;}
			get{return _albumid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int GenreId
		{
			set{ _genreid=value;}
			get{return _genreid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ArtistId
		{
			set{ _artistid=value;}
			get{return _artistid;}
		}
		/// <summary>
		/// 
		/// </summary>
        /// 

        [Required(ErrorMessage=" an album Title is Required")]
        [StringLength(160)]
        [DisplayName("标题")]
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
        /// []
        /// 
        [DataType(DataType.Currency)]
        [Required(ErrorMessage="Price is required")]
        [Range(0.01,100.00,ErrorMessage="PriceMust between 0.01 and 100.00")]
        [DisplayName("价格")]
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
        /// 
        [StringLength(1024)]
        [DisplayName("专辑地址")]
		public string AlbumArtUrl
		{
			set{ _albumarturl=value;}
			get{return _albumarturl;}
		}
        [DisplayName("类型名称")]
        public string genrename { get; set; }
        [DisplayName("艺术家")]
        public string artistname { get; set; }
		#endregion Model

	}
}

