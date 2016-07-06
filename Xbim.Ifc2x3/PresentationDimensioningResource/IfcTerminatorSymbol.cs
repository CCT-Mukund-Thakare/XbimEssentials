// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationDimensioningResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTerminatorSymbol
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTerminatorSymbol : IIfcAnnotationSymbolOccurrence
	{
		IIfcAnnotationCurveOccurrence @AnnotatedCurve { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[ExpressType("IfcTerminatorSymbol", 743)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTerminatorSymbol : IfcAnnotationSymbolOccurrence, IInstantiableEntity, IIfcTerminatorSymbol, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcTerminatorSymbol>
	{
		#region IIfcTerminatorSymbol explicit implementation
		IIfcAnnotationCurveOccurrence IIfcTerminatorSymbol.AnnotatedCurve { 
 
 
			get { return @AnnotatedCurve; } 
			set { AnnotatedCurve = value as IfcAnnotationCurveOccurrence;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTerminatorSymbol(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAnnotationCurveOccurrence _annotatedCurve;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcAnnotationCurveOccurrence @AnnotatedCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _annotatedCurve;
				((IPersistEntity)this).Activate(false);
				return _annotatedCurve;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _annotatedCurve = v, _annotatedCurve, value,  "AnnotatedCurve", 4);
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
					_annotatedCurve = (IfcAnnotationCurveOccurrence)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTerminatorSymbol other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Item != null)
					yield return @Item;
				foreach(var entity in @Styles)
					yield return entity;
				if (@AnnotatedCurve != null)
					yield return @AnnotatedCurve;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@Item != null)
					yield return @Item;
				if (@AnnotatedCurve != null)
					yield return @AnnotatedCurve;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}