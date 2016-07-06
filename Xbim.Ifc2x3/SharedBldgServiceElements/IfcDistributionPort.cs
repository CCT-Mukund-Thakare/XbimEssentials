// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProductExtension;
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
    /// Readonly interface for IfcDistributionPort
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDistributionPort : IIfcPort
	{
		IfcFlowDirectionEnum? @FlowDirection { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[ExpressType("IfcDistributionPort", 178)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDistributionPort : IfcPort, IInstantiableEntity, IIfcDistributionPort, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcDistributionPort>
	{
		#region IIfcDistributionPort explicit implementation
		IfcFlowDirectionEnum? IIfcDistributionPort.FlowDirection { 
 
			get { return @FlowDirection; } 
			set { FlowDirection = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDistributionPort(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcFlowDirectionEnum? _flowDirection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 17)]
		public IfcFlowDirectionEnum? @FlowDirection 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _flowDirection;
				((IPersistEntity)this).Activate(false);
				return _flowDirection;
			} 
			set
			{
				SetValue( v =>  _flowDirection = v, _flowDirection, value,  "FlowDirection", 8);
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
                    _flowDirection = (IfcFlowDirectionEnum) System.Enum.Parse(typeof (IfcFlowDirectionEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDistributionPort other)
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