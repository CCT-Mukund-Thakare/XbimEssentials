// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextStyleWithBoxCharacteristics
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextStyleWithBoxCharacteristics : IPersistEntity, IfcTextStyleSelect
	{
		IfcPositiveLengthMeasure? @BoxHeight { get;  set; }
		IfcPositiveLengthMeasure? @BoxWidth { get;  set; }
		IfcPlaneAngleMeasure? @BoxSlantAngle { get;  set; }
		IfcPlaneAngleMeasure? @BoxRotateAngle { get;  set; }
		IIfcSizeSelect @CharacterSpacing { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcTextStyleWithBoxCharacteristics", 730)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextStyleWithBoxCharacteristics : PersistEntity, IInstantiableEntity, IIfcTextStyleWithBoxCharacteristics, IEquatable<@IfcTextStyleWithBoxCharacteristics>
	{
		#region IIfcTextStyleWithBoxCharacteristics explicit implementation
		IfcPositiveLengthMeasure? IIfcTextStyleWithBoxCharacteristics.BoxHeight { 
 
			get { return @BoxHeight; } 
			set { BoxHeight = value;}
		}	
		IfcPositiveLengthMeasure? IIfcTextStyleWithBoxCharacteristics.BoxWidth { 
 
			get { return @BoxWidth; } 
			set { BoxWidth = value;}
		}	
		IfcPlaneAngleMeasure? IIfcTextStyleWithBoxCharacteristics.BoxSlantAngle { 
 
			get { return @BoxSlantAngle; } 
			set { BoxSlantAngle = value;}
		}	
		IfcPlaneAngleMeasure? IIfcTextStyleWithBoxCharacteristics.BoxRotateAngle { 
 
			get { return @BoxRotateAngle; } 
			set { BoxRotateAngle = value;}
		}	
		IIfcSizeSelect IIfcTextStyleWithBoxCharacteristics.CharacterSpacing { 
 
 
			get { return @CharacterSpacing; } 
			set { CharacterSpacing = value as IfcSizeSelect;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextStyleWithBoxCharacteristics(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _boxHeight;
		private IfcPositiveLengthMeasure? _boxWidth;
		private IfcPlaneAngleMeasure? _boxSlantAngle;
		private IfcPlaneAngleMeasure? _boxRotateAngle;
		private IfcSizeSelect _characterSpacing;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcPositiveLengthMeasure? @BoxHeight 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _boxHeight;
				((IPersistEntity)this).Activate(false);
				return _boxHeight;
			} 
			set
			{
				SetValue( v =>  _boxHeight = v, _boxHeight, value,  "BoxHeight", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcPositiveLengthMeasure? @BoxWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _boxWidth;
				((IPersistEntity)this).Activate(false);
				return _boxWidth;
			} 
			set
			{
				SetValue( v =>  _boxWidth = v, _boxWidth, value,  "BoxWidth", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcPlaneAngleMeasure? @BoxSlantAngle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _boxSlantAngle;
				((IPersistEntity)this).Activate(false);
				return _boxSlantAngle;
			} 
			set
			{
				SetValue( v =>  _boxSlantAngle = v, _boxSlantAngle, value,  "BoxSlantAngle", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcPlaneAngleMeasure? @BoxRotateAngle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _boxRotateAngle;
				((IPersistEntity)this).Activate(false);
				return _boxRotateAngle;
			} 
			set
			{
				SetValue( v =>  _boxRotateAngle = v, _boxRotateAngle, value,  "BoxRotateAngle", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcSizeSelect @CharacterSpacing 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _characterSpacing;
				((IPersistEntity)this).Activate(false);
				return _characterSpacing;
			} 
			set
			{
				SetValue( v =>  _characterSpacing = v, _characterSpacing, value,  "CharacterSpacing", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_boxHeight = value.RealVal;
					return;
				case 1: 
					_boxWidth = value.RealVal;
					return;
				case 2: 
					_boxSlantAngle = value.RealVal;
					return;
				case 3: 
					_boxRotateAngle = value.RealVal;
					return;
				case 4: 
					_characterSpacing = (IfcSizeSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextStyleWithBoxCharacteristics other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}