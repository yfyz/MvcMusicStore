using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// orderdetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class orderdetail
	{
		public orderdetail()
		{}
		#region Model
		private int _orderdetailid;
		private int _orderid;
		private int _albumid;
		private int _quantity;
		private decimal _unitprice;
		/// <summary>
		/// 
		/// </summary>
		public int OrderDetailId
		{
			set{ _orderdetailid=value;}
			get{return _orderdetailid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OrderId
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AlbumId
		{
			set{ _albumid=value;}
			get{return _albumid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Quantity
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal UnitPrice
		{
			set{ _unitprice=value;}
			get{return _unitprice;}
		}
		#endregion Model

	}
}

