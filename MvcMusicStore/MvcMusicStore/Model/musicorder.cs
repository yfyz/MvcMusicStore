using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace Maticsoft.Model
{
	/// <summary>
	/// musicorder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
    [Bind(Exclude = "OrderId")]
	public partial class musicorder
	{
      
		public musicorder()
		{}
		#region Model
		private int _orderid;
		private DateTime _orderdate;
		private string _username;
		private string _firstname;
		private string _lastname;
		private string _address;
		private string _city;
		private string _state;
		private string _postalcode;
		private string _country;
		private string _phone;
		private string _email;
		private decimal _total;
		/// <summary>
		/// 
		/// </summary>
        /// 
        [ScaffoldColumn(false)]
		public int OrderId
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// 
		/// </summary>
        /// 
         [ScaffoldColumn(false)]
		public DateTime OrderDate
		{
			set{ _orderdate=value;}
			get{return _orderdate;}
		}
		/// <summary>
		/// 
		/// </summary>
         [ScaffoldColumn(false)]
        public string Username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
         [Required(ErrorMessage = "First Name is required")]
         [DisplayName("First Name")]
         [StringLength(160)]
        public string FirstName
		{
			set{ _firstname=value;}
			get{return _firstname;}
		}
		/// <summary>
		/// 
		/// </summary>
         [Required(ErrorMessage = "Last Name is required")]
         [DisplayName("Last Name")]
         [StringLength(160)]
        public string LastName
		{
			set{ _lastname=value;}
			get{return _lastname;}
		}
		/// <summary>
		/// 
		/// </summary>
         [Required(ErrorMessage = "Address is required")]
         [StringLength(70)]
        public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
         [Required(ErrorMessage = "City is required")]
         [StringLength(40)]
        public string City
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
         [Required(ErrorMessage = "State is required")]
         [StringLength(40)]
        public string State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
         [Required(ErrorMessage = "Postal Code is required")]
         [DisplayName("Postal Code")]
         [StringLength(10)]
        public string PostalCode
		{
			set{ _postalcode=value;}
			get{return _postalcode;}
		}
		/// <summary>
		/// 
		/// </summary>
         [Required(ErrorMessage = "Country is required")]
         [StringLength(40)]
        public string Country
		{
			set{ _country=value;}
			get{return _country;}
		}
		/// <summary>
		/// 
		/// </summary>
        [Required(ErrorMessage = "Phone is required")]
        [StringLength(24)]
        [DataType(DataType.PhoneNumber)]
        public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
        [Required(ErrorMessage = "Email Address is required")]
        [DisplayName("Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
        ErrorMessage = "Email is is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Total
		{
			set{ _total=value;}
			get{return _total;}
		}
        public List<orderdetail> OrderDetail { get; set; }
		#endregion Model

	}
}

