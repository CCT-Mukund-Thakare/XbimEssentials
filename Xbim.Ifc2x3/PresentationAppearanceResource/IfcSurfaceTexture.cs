// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
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
    /// Readonly interface for IfcSurfaceTexture
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceTexture : IPersistEntity
	{
		bool @RepeatS { get;  set; }
		bool @RepeatT { get;  set; }
		IfcSurfaceTextureEnum @TextureType { get;  set; }
		IIfcCartesianTransformationOperator2D @TextureTransform { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcSurfaceTexture", 722)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSurfaceTexture : PersistEntity, IIfcSurfaceTexture, IEquatable<@IfcSurfaceTexture>
	{
		#region IIfcSurfaceTexture explicit implementation
		bool IIfcSurfaceTexture.RepeatS { 
 
			get { return @RepeatS; } 
			set { RepeatS = value;}
		}	
		bool IIfcSurfaceTexture.RepeatT { 
 
			get { return @RepeatT; } 
			set { RepeatT = value;}
		}	
		IfcSurfaceTextureEnum IIfcSurfaceTexture.TextureType { 
 
			get { return @TextureType; } 
			set { TextureType = value;}
		}	
		IIfcCartesianTransformationOperator2D IIfcSurfaceTexture.TextureTransform { 
 
 
			get { return @TextureTransform; } 
			set { TextureTransform = value as IfcCartesianTransformationOperator2D;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceTexture(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private bool _repeatS;
		private bool _repeatT;
		private IfcSurfaceTextureEnum _textureType;
		private IfcCartesianTransformationOperator2D _textureTransform;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public bool @RepeatS 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _repeatS;
				((IPersistEntity)this).Activate(false);
				return _repeatS;
			} 
			set
			{
				SetValue( v =>  _repeatS = v, _repeatS, value,  "RepeatS", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public bool @RepeatT 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _repeatT;
				((IPersistEntity)this).Activate(false);
				return _repeatT;
			} 
			set
			{
				SetValue( v =>  _repeatT = v, _repeatT, value,  "RepeatT", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 3)]
		public IfcSurfaceTextureEnum @TextureType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textureType;
				((IPersistEntity)this).Activate(false);
				return _textureType;
			} 
			set
			{
				SetValue( v =>  _textureType = v, _textureType, value,  "TextureType", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcCartesianTransformationOperator2D @TextureTransform 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textureTransform;
				((IPersistEntity)this).Activate(false);
				return _textureTransform;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _textureTransform = v, _textureTransform, value,  "TextureTransform", 4);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_repeatS = value.BooleanVal;
					return;
				case 1: 
					_repeatT = value.BooleanVal;
					return;
				case 2: 
                    _textureType = (IfcSurfaceTextureEnum) System.Enum.Parse(typeof (IfcSurfaceTextureEnum), value.EnumVal, true);
					return;
				case 3: 
					_textureTransform = (IfcCartesianTransformationOperator2D)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceTexture other)
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