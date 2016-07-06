// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProductExtension;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedBldgServiceElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDistributionControlElement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDistributionControlElement : IIfcDistributionElement
	{
		IfcIdentifier? @ControlElementId { get;  set; }
		IEnumerable<IIfcRelFlowControlElements> @AssignedToFlowElement {  get; }
	
	}
}

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[ExpressType("IfcDistributionControlElement", 468)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDistributionControlElement : IfcDistributionElement, IInstantiableEntity, IIfcDistributionControlElement, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcDistributionControlElement>
	{
		#region IIfcDistributionControlElement explicit implementation
		IfcIdentifier? IIfcDistributionControlElement.ControlElementId { 
 
			get { return @ControlElementId; } 
			set { ControlElementId = value;}
		}	
		 
		IEnumerable<IIfcRelFlowControlElements> IIfcDistributionControlElement.AssignedToFlowElement {  get { return @AssignedToFlowElement; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDistributionControlElement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcIdentifier? _controlElementId;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 27)]
		public IfcIdentifier? @ControlElementId 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _controlElementId;
				((IPersistEntity)this).Activate(false);
				return _controlElementId;
			} 
			set
			{
				SetValue( v =>  _controlElementId = v, _controlElementId, value,  "ControlElementId", 9);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedControlElements")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 28)]
		public IEnumerable<IfcRelFlowControlElements> @AssignedToFlowElement 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelFlowControlElements>(e => e.RelatedControlElements != null &&  e.RelatedControlElements.Contains(this), "RelatedControlElements", this);
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
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
					_controlElementId = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDistributionControlElement other)
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
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}