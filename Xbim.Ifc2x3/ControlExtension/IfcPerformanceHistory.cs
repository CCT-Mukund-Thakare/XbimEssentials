// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ControlExtension;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPerformanceHistory
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPerformanceHistory : IIfcControl
	{
		IfcLabel @LifeCyclePhase { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ControlExtension
{
	[ExpressType("IfcPerformanceHistory", 710)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPerformanceHistory : IfcControl, IInstantiableEntity, IIfcPerformanceHistory, IContainsEntityReferences, IEquatable<@IfcPerformanceHistory>
	{
		#region IIfcPerformanceHistory explicit implementation
		IfcLabel IIfcPerformanceHistory.LifeCyclePhase { 
 
			get { return @LifeCyclePhase; } 
			set { LifeCyclePhase = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPerformanceHistory(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel _lifeCyclePhase;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcLabel @LifeCyclePhase 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lifeCyclePhase;
				((IPersistEntity)this).Activate(false);
				return _lifeCyclePhase;
			} 
			set
			{
				SetValue( v =>  _lifeCyclePhase = v, _lifeCyclePhase, value,  "LifeCyclePhase", 6);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_lifeCyclePhase = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPerformanceHistory other)
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
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}