// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.StructuralAnalysisDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralResultGroup
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralResultGroup : IIfcGroup
	{
		IfcAnalysisTheoryTypeEnum @TheoryType { get;  set; }
		IIfcStructuralLoadGroup @ResultForLoadGroup { get;  set; }
		IfcBoolean @IsLinear { get;  set; }
		IEnumerable<IIfcStructuralAnalysisModel> @ResultGroupFor {  get; }
	
	}
}

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[ExpressType("IfcStructuralResultGroup", 532)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralResultGroup : IfcGroup, IInstantiableEntity, IIfcStructuralResultGroup, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcStructuralResultGroup>
	{
		#region IIfcStructuralResultGroup explicit implementation
		IfcAnalysisTheoryTypeEnum IIfcStructuralResultGroup.TheoryType { 
 
			get { return @TheoryType; } 
			set { TheoryType = value;}
		}	
		IIfcStructuralLoadGroup IIfcStructuralResultGroup.ResultForLoadGroup { 
 
 
			get { return @ResultForLoadGroup; } 
			set { ResultForLoadGroup = value as IfcStructuralLoadGroup;}
		}	
		IfcBoolean IIfcStructuralResultGroup.IsLinear { 
 
			get { return @IsLinear; } 
			set { IsLinear = value;}
		}	
		 
		IEnumerable<IIfcStructuralAnalysisModel> IIfcStructuralResultGroup.ResultGroupFor {  get { return @ResultGroupFor; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralResultGroup(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAnalysisTheoryTypeEnum _theoryType;
		private IfcStructuralLoadGroup _resultForLoadGroup;
		private IfcBoolean _isLinear;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 18)]
		public IfcAnalysisTheoryTypeEnum @TheoryType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _theoryType;
				((IPersistEntity)this).Activate(false);
				return _theoryType;
			} 
			set
			{
				SetValue( v =>  _theoryType = v, _theoryType, value,  "TheoryType", 6);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 19)]
		public IfcStructuralLoadGroup @ResultForLoadGroup 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _resultForLoadGroup;
				((IPersistEntity)this).Activate(false);
				return _resultForLoadGroup;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _resultForLoadGroup = v, _resultForLoadGroup, value,  "ResultForLoadGroup", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 20)]
		public IfcBoolean @IsLinear 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _isLinear;
				((IPersistEntity)this).Activate(false);
				return _isLinear;
			} 
			set
			{
				SetValue( v =>  _isLinear = v, _isLinear, value,  "IsLinear", 8);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("HasResults")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 21)]
		public IEnumerable<IfcStructuralAnalysisModel> @ResultGroupFor 
		{ 
			get 
			{
				return Model.Instances.Where<IfcStructuralAnalysisModel>(e => e.HasResults != null &&  e.HasResults.Contains(this), "HasResults", this);
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
                    _theoryType = (IfcAnalysisTheoryTypeEnum) System.Enum.Parse(typeof (IfcAnalysisTheoryTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_resultForLoadGroup = (IfcStructuralLoadGroup)(value.EntityVal);
					return;
				case 7: 
					_isLinear = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralResultGroup other)
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
				if (@ResultForLoadGroup != null)
					yield return @ResultForLoadGroup;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ResultForLoadGroup != null)
					yield return @ResultForLoadGroup;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}