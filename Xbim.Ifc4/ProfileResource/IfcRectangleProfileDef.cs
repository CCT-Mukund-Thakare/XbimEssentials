// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProfileResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRectangleProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRectangleProfileDef : IIfcParameterizedProfileDef
	{
		IfcPositiveLengthMeasure @XDim { get;  set; }
		IfcPositiveLengthMeasure @YDim { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IfcRectangleProfileDef", 103)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRectangleProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IIfcRectangleProfileDef, IContainsEntityReferences, IEquatable<@IfcRectangleProfileDef>
	{
		#region IIfcRectangleProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcRectangleProfileDef.XDim { 
 
			get { return @XDim; } 
			set { XDim = value;}
		}	
		IfcPositiveLengthMeasure IIfcRectangleProfileDef.YDim { 
 
			get { return @YDim; } 
			set { YDim = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRectangleProfileDef(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _xDim;
		private IfcPositiveLengthMeasure _yDim;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcPositiveLengthMeasure @XDim 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _xDim;
				((IPersistEntity)this).Activate(false);
				return _xDim;
			} 
			set
			{
				SetValue( v =>  _xDim = v, _xDim, value,  "XDim", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcPositiveLengthMeasure @YDim 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _yDim;
				((IPersistEntity)this).Activate(false);
				return _yDim;
			} 
			set
			{
				SetValue( v =>  _yDim = v, _yDim, value,  "YDim", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_xDim = value.RealVal;
					return;
				case 4: 
					_yDim = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRectangleProfileDef other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}