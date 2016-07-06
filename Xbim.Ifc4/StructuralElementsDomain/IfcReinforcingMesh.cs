// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.StructuralElementsDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcReinforcingMesh
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcReinforcingMesh : IIfcReinforcingElement
	{
		IfcPositiveLengthMeasure? @MeshLength { get;  set; }
		IfcPositiveLengthMeasure? @MeshWidth { get;  set; }
		IfcPositiveLengthMeasure? @LongitudinalBarNominalDiameter { get;  set; }
		IfcPositiveLengthMeasure? @TransverseBarNominalDiameter { get;  set; }
		IfcAreaMeasure? @LongitudinalBarCrossSectionArea { get;  set; }
		IfcAreaMeasure? @TransverseBarCrossSectionArea { get;  set; }
		IfcPositiveLengthMeasure? @LongitudinalBarSpacing { get;  set; }
		IfcPositiveLengthMeasure? @TransverseBarSpacing { get;  set; }
		IfcReinforcingMeshTypeEnum? @PredefinedType { get;  set; }
	
	}
}

namespace Xbim.Ifc4.StructuralElementsDomain
{
	[ExpressType("IfcReinforcingMesh", 531)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcingMesh : IfcReinforcingElement, IInstantiableEntity, IIfcReinforcingMesh, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcReinforcingMesh>
	{
		#region IIfcReinforcingMesh explicit implementation
		IfcPositiveLengthMeasure? IIfcReinforcingMesh.MeshLength { 
 
			get { return @MeshLength; } 
			set { MeshLength = value;}
		}	
		IfcPositiveLengthMeasure? IIfcReinforcingMesh.MeshWidth { 
 
			get { return @MeshWidth; } 
			set { MeshWidth = value;}
		}	
		IfcPositiveLengthMeasure? IIfcReinforcingMesh.LongitudinalBarNominalDiameter { 
 
			get { return @LongitudinalBarNominalDiameter; } 
			set { LongitudinalBarNominalDiameter = value;}
		}	
		IfcPositiveLengthMeasure? IIfcReinforcingMesh.TransverseBarNominalDiameter { 
 
			get { return @TransverseBarNominalDiameter; } 
			set { TransverseBarNominalDiameter = value;}
		}	
		IfcAreaMeasure? IIfcReinforcingMesh.LongitudinalBarCrossSectionArea { 
 
			get { return @LongitudinalBarCrossSectionArea; } 
			set { LongitudinalBarCrossSectionArea = value;}
		}	
		IfcAreaMeasure? IIfcReinforcingMesh.TransverseBarCrossSectionArea { 
 
			get { return @TransverseBarCrossSectionArea; } 
			set { TransverseBarCrossSectionArea = value;}
		}	
		IfcPositiveLengthMeasure? IIfcReinforcingMesh.LongitudinalBarSpacing { 
 
			get { return @LongitudinalBarSpacing; } 
			set { LongitudinalBarSpacing = value;}
		}	
		IfcPositiveLengthMeasure? IIfcReinforcingMesh.TransverseBarSpacing { 
 
			get { return @TransverseBarSpacing; } 
			set { TransverseBarSpacing = value;}
		}	
		IfcReinforcingMeshTypeEnum? IIfcReinforcingMesh.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcingMesh(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _meshLength;
		private IfcPositiveLengthMeasure? _meshWidth;
		private IfcPositiveLengthMeasure? _longitudinalBarNominalDiameter;
		private IfcPositiveLengthMeasure? _transverseBarNominalDiameter;
		private IfcAreaMeasure? _longitudinalBarCrossSectionArea;
		private IfcAreaMeasure? _transverseBarCrossSectionArea;
		private IfcPositiveLengthMeasure? _longitudinalBarSpacing;
		private IfcPositiveLengthMeasure? _transverseBarSpacing;
		private IfcReinforcingMeshTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 34)]
		public IfcPositiveLengthMeasure? @MeshLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _meshLength;
				((IPersistEntity)this).Activate(false);
				return _meshLength;
			} 
			set
			{
				SetValue( v =>  _meshLength = v, _meshLength, value,  "MeshLength", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 35)]
		public IfcPositiveLengthMeasure? @MeshWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _meshWidth;
				((IPersistEntity)this).Activate(false);
				return _meshWidth;
			} 
			set
			{
				SetValue( v =>  _meshWidth = v, _meshWidth, value,  "MeshWidth", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 36)]
		public IfcPositiveLengthMeasure? @LongitudinalBarNominalDiameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longitudinalBarNominalDiameter;
				((IPersistEntity)this).Activate(false);
				return _longitudinalBarNominalDiameter;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarNominalDiameter = v, _longitudinalBarNominalDiameter, value,  "LongitudinalBarNominalDiameter", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 37)]
		public IfcPositiveLengthMeasure? @TransverseBarNominalDiameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transverseBarNominalDiameter;
				((IPersistEntity)this).Activate(false);
				return _transverseBarNominalDiameter;
			} 
			set
			{
				SetValue( v =>  _transverseBarNominalDiameter = v, _transverseBarNominalDiameter, value,  "TransverseBarNominalDiameter", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 38)]
		public IfcAreaMeasure? @LongitudinalBarCrossSectionArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longitudinalBarCrossSectionArea;
				((IPersistEntity)this).Activate(false);
				return _longitudinalBarCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarCrossSectionArea = v, _longitudinalBarCrossSectionArea, value,  "LongitudinalBarCrossSectionArea", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 39)]
		public IfcAreaMeasure? @TransverseBarCrossSectionArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transverseBarCrossSectionArea;
				((IPersistEntity)this).Activate(false);
				return _transverseBarCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _transverseBarCrossSectionArea = v, _transverseBarCrossSectionArea, value,  "TransverseBarCrossSectionArea", 15);
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 40)]
		public IfcPositiveLengthMeasure? @LongitudinalBarSpacing 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longitudinalBarSpacing;
				((IPersistEntity)this).Activate(false);
				return _longitudinalBarSpacing;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarSpacing = v, _longitudinalBarSpacing, value,  "LongitudinalBarSpacing", 16);
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 41)]
		public IfcPositiveLengthMeasure? @TransverseBarSpacing 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transverseBarSpacing;
				((IPersistEntity)this).Activate(false);
				return _transverseBarSpacing;
			} 
			set
			{
				SetValue( v =>  _transverseBarSpacing = v, _transverseBarSpacing, value,  "TransverseBarSpacing", 17);
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 42)]
		public IfcReinforcingMeshTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 18);
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
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
					_meshLength = value.RealVal;
					return;
				case 10: 
					_meshWidth = value.RealVal;
					return;
				case 11: 
					_longitudinalBarNominalDiameter = value.RealVal;
					return;
				case 12: 
					_transverseBarNominalDiameter = value.RealVal;
					return;
				case 13: 
					_longitudinalBarCrossSectionArea = value.RealVal;
					return;
				case 14: 
					_transverseBarCrossSectionArea = value.RealVal;
					return;
				case 15: 
					_longitudinalBarSpacing = value.RealVal;
					return;
				case 16: 
					_transverseBarSpacing = value.RealVal;
					return;
				case 17: 
                    _predefinedType = (IfcReinforcingMeshTypeEnum) System.Enum.Parse(typeof (IfcReinforcingMeshTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcReinforcingMesh other)
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