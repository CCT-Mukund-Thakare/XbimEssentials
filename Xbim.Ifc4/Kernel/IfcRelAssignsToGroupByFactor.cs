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
using Xbim.Ifc4.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelAssignsToGroupByFactor
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelAssignsToGroupByFactor : IIfcRelAssignsToGroup
	{
		IfcRatioMeasure @Factor { get;  set; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcRelAssignsToGroupByFactor", 1248)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssignsToGroupByFactor : IfcRelAssignsToGroup, IInstantiableEntity, IIfcRelAssignsToGroupByFactor, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelAssignsToGroupByFactor>
	{
		#region IIfcRelAssignsToGroupByFactor explicit implementation
		IfcRatioMeasure IIfcRelAssignsToGroupByFactor.Factor { 
 
			get { return @Factor; } 
			set { Factor = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssignsToGroupByFactor(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcRatioMeasure _factor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcRatioMeasure @Factor 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _factor;
				((IPersistEntity)this).Activate(false);
				return _factor;
			} 
			set
			{
				SetValue( v =>  _factor = v, _factor, value,  "Factor", 8);
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
				case 3: 
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_factor = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelAssignsToGroupByFactor other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if (@RelatingGroup != null)
					yield return @RelatingGroup;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if (@RelatingGroup != null)
					yield return @RelatingGroup;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}