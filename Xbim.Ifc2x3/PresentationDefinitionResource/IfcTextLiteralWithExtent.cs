// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationDefinitionResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextLiteralWithExtent
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextLiteralWithExtent : IIfcTextLiteral
	{
		IIfcPlanarExtent @Extent { get;  set; }
		IfcBoxAlignment @BoxAlignment { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[ExpressType("IfcTextLiteralWithExtent", 426)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextLiteralWithExtent : IfcTextLiteral, IInstantiableEntity, IIfcTextLiteralWithExtent, IContainsEntityReferences, IEquatable<@IfcTextLiteralWithExtent>
	{
		#region IIfcTextLiteralWithExtent explicit implementation
		IIfcPlanarExtent IIfcTextLiteralWithExtent.Extent { 
 
 
			get { return @Extent; } 
			set { Extent = value as IfcPlanarExtent;}
		}	
		IfcBoxAlignment IIfcTextLiteralWithExtent.BoxAlignment { 
 
			get { return @BoxAlignment; } 
			set { BoxAlignment = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextLiteralWithExtent(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPlanarExtent _extent;
		private IfcBoxAlignment _boxAlignment;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcPlanarExtent @Extent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _extent;
				((IPersistEntity)this).Activate(false);
				return _extent;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _extent = v, _extent, value,  "Extent", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcBoxAlignment @BoxAlignment 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _boxAlignment;
				((IPersistEntity)this).Activate(false);
				return _boxAlignment;
			} 
			set
			{
				SetValue( v =>  _boxAlignment = v, _boxAlignment, value,  "BoxAlignment", 5);
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
					_extent = (IfcPlanarExtent)(value.EntityVal);
					return;
				case 4: 
					_boxAlignment = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextLiteralWithExtent other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Placement != null)
					yield return @Placement;
				if (@Extent != null)
					yield return @Extent;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}