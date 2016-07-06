// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ProcessExtension;
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
    /// Readonly interface for IfcProcess
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcProcess : IIfcObject, IfcProcessSelect
	{
		IfcIdentifier? @Identification { get;  set; }
		IfcText? @LongDescription { get;  set; }
		IEnumerable<IIfcRelSequence> @IsPredecessorTo {  get; }
		IEnumerable<IIfcRelSequence> @IsSuccessorFrom {  get; }
		IEnumerable<IIfcRelAssignsToProcess> @OperatesOn {  get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcProcess", 73)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcProcess : IfcObject, IIfcProcess, IEquatable<@IfcProcess>
	{
		#region IIfcProcess explicit implementation
		IfcIdentifier? IIfcProcess.Identification { 
 
			get { return @Identification; } 
			set { Identification = value;}
		}	
		IfcText? IIfcProcess.LongDescription { 
 
			get { return @LongDescription; } 
			set { LongDescription = value;}
		}	
		 
		IEnumerable<IIfcRelSequence> IIfcProcess.IsPredecessorTo {  get { return @IsPredecessorTo; } }
		IEnumerable<IIfcRelSequence> IIfcProcess.IsSuccessorFrom {  get { return @IsSuccessorFrom; } }
		IEnumerable<IIfcRelAssignsToProcess> IIfcProcess.OperatesOn {  get { return @OperatesOn; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProcess(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcIdentifier? _identification;
		private IfcText? _longDescription;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 17)]
		public IfcIdentifier? @Identification 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _identification;
				((IPersistEntity)this).Activate(false);
				return _identification;
			} 
			set
			{
				SetValue( v =>  _identification = v, _identification, value,  "Identification", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 18)]
		public IfcText? @LongDescription 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longDescription;
				((IPersistEntity)this).Activate(false);
				return _longDescription;
			} 
			set
			{
				SetValue( v =>  _longDescription = v, _longDescription, value,  "LongDescription", 7);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatingProcess")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 19)]
		public IEnumerable<IfcRelSequence> @IsPredecessorTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSequence>(e => Equals(e.RelatingProcess), "RelatingProcess", this);
			} 
		}
		[InverseProperty("RelatedProcess")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 20)]
		public IEnumerable<IfcRelSequence> @IsSuccessorFrom 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSequence>(e => Equals(e.RelatedProcess), "RelatedProcess", this);
			} 
		}
		[InverseProperty("RelatingProcess")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 21)]
		public IEnumerable<IfcRelAssignsToProcess> @OperatesOn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssignsToProcess>(e => Equals(e.RelatingProcess), "RelatingProcess", this);
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
					_identification = value.StringVal;
					return;
				case 6: 
					_longDescription = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProcess other)
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