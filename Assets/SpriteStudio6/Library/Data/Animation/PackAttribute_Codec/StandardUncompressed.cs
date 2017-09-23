﻿/**
	SpriteStudio6 Player for Unity

	Copyright(C) Web Technology Corp. 
	All rights reserved.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class Library_SpriteStudio6
{
	public static partial class Data
	{
		public partial class Animation
		{
			public static partial class PackAttribute
			{
				/* ----------------------------------------------- Classes, Structs & Interfaces */
				#region Classes, Structs & Interfaces
				public static class StandardUncompressed
				{
					/* ----------------------------------------------- Enums & Constants */
					#region Enums & Constants
					public static readonly Library_SpriteStudio6.Data.Animation.PackAttribute.CapacityContainer Capacity = new Library_SpriteStudio6.Data.Animation.PackAttribute.CapacityContainer(
						true,		/* Status */
						false,		/* Position *//* Use only in front stage of other pack formats, since performance is very poor. */
						false,		/* Rotation *//* Use only in front stage of other pack formats, since performance is very poor. */
						false,		/* Scaling *//* Use only in front stage of other pack formats, since performance is very poor. */
						true,		/* RateOpacity */
						true,		/* PositionAnchor */
						true,		/* SizeForce */
						false,		/* UserData (Trigger) *//* Not Supported */
						false,		/* Instance (Trigger) *//* Not Supported */
						false,		/* Effect (Trigger) *//* Not Supported */
						false,		/* RadiusCollision *//* Use only in front stage of other pack formats, since performance is very poor. */
						true,		/* Plain.Cell */
						true,		/* Plain.ColorBlend */
						true,		/* Plain.VertexCorrection */
						true,		/* Plain.OffsetPivot */
						true,		/* Plain.PositionTexture */
						true,		/* Plain.ScalingTexture */
						true,		/* Plain.RotationTexture */
						true,		/* Fix.IndexCellMap */
						true,		/* Fix.Coordinate */
						true,		/* Fix.ColorBlend */
						true,		/* Fix.UV0 */
						false,		/* Fix.SizeCollision *//* Use only in front stage of other pack formats, since performance is very poor. */
						false		/* Fix.PivotCollision *//* Use only in front stage of other pack formats, since performance is very poor. */
					);

					public const string ID = "StandardUncompressed";

					internal readonly static InterfaceFunctionInt FunctionInt = new InterfaceFunctionInt();
					internal readonly static InterfaceFunctionFloat FunctionFloat = new InterfaceFunctionFloat();
					internal readonly static InterfaceFunctionVector2 FunctionVector2 = new InterfaceFunctionVector2();
					internal readonly static InterfaceFunctionVector3 FunctionVector3 = new InterfaceFunctionVector3();
					internal readonly static InterfaceFunctionStatus FunctionStatus = new InterfaceFunctionStatus();
					internal readonly static InterfaceFunctionCell FunctionCell = new InterfaceFunctionCell();
					internal readonly static InterfaceFunctionColorBlend FunctionColorBlend = new InterfaceFunctionColorBlend();
					internal readonly static InterfaceFunctionVertexCorrection FunctionVertexCorrection = new InterfaceFunctionVertexCorrection();
//					internal readonly static InterfaceFunctionUserData FunctionUserData = new InterfaceFunctionUserData();
//					internal readonly static InterfaceFunctionInstance FunctionInstance = new InterfaceFunctionInstance();
//					internal readonly static InterfaceFunctionEffect FunctionEffect = new InterfaceFunctionEffect();
					internal readonly static InterfaceFunctionCoordinateFix FunctionCoordinateFix = new InterfaceFunctionCoordinateFix();
					internal readonly static InterfaceFunctionColorBlendFix FunctionColorBlendFix = new InterfaceFunctionColorBlendFix();
					internal readonly static InterfaceFunctionUVFix FunctionUVFix = new InterfaceFunctionUVFix();
					#endregion Enums & Constants

					/* ----------------------------------------------- Classes, Structs & Interfaces */
					#region Classes, Structs & Interfaces
					public class InterfaceFunctionInt : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerInt
					{
						/* ----------------------------------------------- Functions */
						#region Functions
						public bool ValueGet(	ref int outValue,
												ref int outFrameKey,
												Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerInt container,
												ref Library_SpriteStudio6.Data.Animation.PackAttribute.ArgumentContainer argument
											)
						{
							return(Library_SpriteStudio6.Data.Animation.PackAttribute.StandardUncompressed.ValueGet(ref outValue, ref outFrameKey, argument.Frame, container.TableValue));
						}

						public bool Pack(	Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerInt container,
											string nameAttribute,
											int countFrame,
											Library_SpriteStudio6.Data.Animation.Parts.FlagBitStatus flagStatusParts,
											int[] tableOrderDraw,
											params Library_SpriteStudio6.Data.Animation.Attribute.Importer.AttributeInt[] listKeyData
										)
						{	/* MEMO: "ListKeyData.Length" is always 1 *//* MEMO: No inheritance is related to attribute stored in this type. */
							container.TableCodeValue = new Library_SpriteStudio6.Data.Animation.PackAttribute.CodeValueContainer[0];

							if(0 >= listKeyData[0].CountGetKey())
							{
								container.TableValue = new int[0];
								return(true);
							}

							/* MEMO: Default value when attribute has no key data differs depending on attribute. */
							int valueDefault = 0;
							switch(nameAttribute)
							{
								case Library_SpriteStudio6.Data.Animation.Attribute.Importer.NameAttributeFixIndexCellMap:
									valueDefault = -1;
									break;

								default:
									valueDefault = 0;
									break;
							}

							int value;
							container.TableValue = new int[countFrame];
							for(int i=0; i<countFrame; i++)
							{
								if(false == listKeyData[0].ValueGet(out value, i))
								{
									value = valueDefault;
								}
								container.TableValue[i] = value;
							}
							return(true);
						}
						#endregion Functions
					}

					public class InterfaceFunctionFloat : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerFloat
					{
						/* ----------------------------------------------- Functions */
						#region Functions
						public bool ValueGet(	ref float outValue,
												ref int outFrameKey,
												Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerFloat container,
												ref Library_SpriteStudio6.Data.Animation.PackAttribute.ArgumentContainer argument
											)
						{
							return(Library_SpriteStudio6.Data.Animation.PackAttribute.StandardUncompressed.ValueGet(ref outValue, ref outFrameKey, argument.Frame, container.TableValue));
						}

						public bool Pack(	Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerFloat container,
											string nameAttribute,
											int countFrame,
											Library_SpriteStudio6.Data.Animation.Parts.FlagBitStatus flagStatusParts,
											int[] tableOrderDraw,
											params Library_SpriteStudio6.Data.Animation.Attribute.Importer.AttributeFloat[] listKeyData
										)
						{	/* MEMO: "ListKeyData.Length" is always 1 */
							container.TableCodeValue = new Library_SpriteStudio6.Data.Animation.PackAttribute.CodeValueContainer[0];

							/* MEMO: In attributes with the float value, default value when has no key differs only "RateOpacity". */
							/*       RateOpacity = 1.0f / other = 0.0f                                                             */
							float value;
							container.TableValue = new float[countFrame];
							switch(nameAttribute)
							{
								case Library_SpriteStudio6.Data.Animation.Attribute.Importer.NameAttributeRateOpacity:
									/* MEMO: Attribute"RateOpacity" inherits value. */
									for(int i=0; i<countFrame; i++)
									{
										Library_SpriteStudio6.Data.Animation.Attribute.Importer.Inheritance.ValueGetFloatMultiple(out value, listKeyData[0], i, 1.0f);
										container.TableValue[i] = value;
									}
									break;

								default:
									if(0 >= listKeyData[0].CountGetKey())
									{
										container.TableValue = new float[0];
										return(true);
									}

									for(int i=0; i<countFrame; i++)
									{
										if(false == listKeyData[0].ValueGet(out value, i))
										{
											value = 0.0f;
										}
										container.TableValue[i] = value;
									}
									break;
							}
							return(true);
						}
						#endregion Functions
					}

					public class InterfaceFunctionVector2 : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerVector2
					{
						/* ----------------------------------------------- Functions */
						#region Functions
						public bool ValueGet(	ref Vector2 outValue,
												ref int outFrameKey,
												Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerVector2 container,
												ref Library_SpriteStudio6.Data.Animation.PackAttribute.ArgumentContainer argument
											)
						{
							return(Library_SpriteStudio6.Data.Animation.PackAttribute.StandardUncompressed.ValueGet(ref outValue, ref outFrameKey, argument.Frame, container.TableValue));
						}

						public bool Pack(	Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerVector2 container,
											string nameAttribute,
											int countFrame,
											Library_SpriteStudio6.Data.Animation.Parts.FlagBitStatus flagStatusParts,
											int[] tableOrderDraw,
											params Library_SpriteStudio6.Data.Animation.Attribute.Importer.AttributeFloat[] listKeyData
										)
						{	/* MEMO: "ListKeyData.Length" is always 2 (X, Y) *//* MEMO: No inheritance is related to attribute stored in this type. */
							container.TableCodeValue = new Library_SpriteStudio6.Data.Animation.PackAttribute.CodeValueContainer[0];

							if((0 >= listKeyData[0].CountGetKey()) && (0 >= listKeyData[1].CountGetKey()))
							{
								container.TableValue = new Vector2[0];
								return(true);
							}

							/* MEMO: For attributes of the scales, default value when has no key is 1.0f. */
							float valueDefault = 0.0f;
							switch(nameAttribute)
							{
								case Library_SpriteStudio6.Data.Animation.Attribute.Importer.NameAttributeScaling: 
								case Library_SpriteStudio6.Data.Animation.Attribute.Importer.NameAttributePlainScalingTexture: 
									valueDefault = 1.0f;
									break;

								default:
									valueDefault = 0.0f;
									break;
							}

							float value;
							container.TableValue = new Vector2[countFrame];
							for(int i=0; i<countFrame; i++)
							{
								if(false == listKeyData[0].ValueGet(out value, i))
								{
									value = valueDefault;
								}
								container.TableValue[i].x = value;

								if(false == listKeyData[1].ValueGet(out value, i))
								{
									value = valueDefault;
								}
								container.TableValue[i].y = value;
							}
							return(true);
						}
						#endregion Functions
					}

					public class InterfaceFunctionVector3 : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerVector3
					{
						/* ----------------------------------------------- Functions */
						#region Functions
						public bool ValueGet(	ref Vector3 outValue,
												ref int outFrameKey,
												Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerVector3 container,
												ref Library_SpriteStudio6.Data.Animation.PackAttribute.ArgumentContainer argument
											)
						{
							return(Library_SpriteStudio6.Data.Animation.PackAttribute.StandardUncompressed.ValueGet(ref outValue, ref outFrameKey, argument.Frame, container.TableValue));
						}

						public bool Pack(	Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerVector3 container,
											string nameAttribute,
											int countFrame,
											Library_SpriteStudio6.Data.Animation.Parts.FlagBitStatus flagStatusParts,
											int[] tableOrderDraw,
											params Library_SpriteStudio6.Data.Animation.Attribute.Importer.AttributeFloat[] listKeyData
										)
						{	/* MEMO: "ListKeyData.Length" is always 3 (X, Y, Z) *//* MEMO: No inheritance is related to attribute stored in this type. */
							container.TableCodeValue = new Library_SpriteStudio6.Data.Animation.PackAttribute.CodeValueContainer[0];

							if((0 >= listKeyData[0].CountGetKey()) && (0 >= listKeyData[1].CountGetKey()) && (0 >= listKeyData[2].CountGetKey()))
							{
								container.TableValue = new Vector3[0];
								return(true);
							}

							float valueDefault = 0.0f;
							float value;
							container.TableValue = new Vector3[countFrame];
							for(int i=0; i<countFrame; i++)
							{
								if(false == listKeyData[0].ValueGet(out value, i))
								{
									value = valueDefault;
								}
								container.TableValue[i].x = value;
								
								if(false == listKeyData[1].ValueGet(out value, i))
								{
									value = valueDefault;
								}
								container.TableValue[i].y = value;

								if(false == listKeyData[2].ValueGet(out value, i))
								{
									value = valueDefault;
								}
								container.TableValue[i].z = value;
							}
							return(true);
						}
						#endregion Functions
					}

					public class InterfaceFunctionStatus : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerStatus
					{
						/* ----------------------------------------------- Functions */
						#region Functions
						public bool ValueGet(	ref Library_SpriteStudio6.Data.Animation.Attribute.Status outValue,
												ref int outFrameKey,
												Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerStatus container,
												ref Library_SpriteStudio6.Data.Animation.PackAttribute.ArgumentContainer argument
											)
						{
							return(Library_SpriteStudio6.Data.Animation.PackAttribute.StandardUncompressed.ValueGet(ref outValue, ref outFrameKey, argument.Frame, container.TableValue));
						}

						public bool Pack(	Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerStatus container,
											string nameAttribute,
											int countFrame,
											Library_SpriteStudio6.Data.Animation.Parts.FlagBitStatus flagStatusParts,
											int[] tableOrderDraw,
											params Library_SpriteStudio6.Data.Animation.Attribute.Importer.AttributeBool[] listKeyData
										)
						{	/* MEMO: "ListKeyData.Length" is always 5 (Hide, FlipX, FlipY, FlipTextureX, FlipTextureY) */
							container.TableCodeValue = new Library_SpriteStudio6.Data.Animation.PackAttribute.CodeValueContainer[0];

							/* MEMO: Attribute"Status" is never omitted. */
							container.TableValue = new Library_SpriteStudio6.Data.Animation.Attribute.Status[countFrame];
							bool valueAttribute;
							for(int i=0; i<countFrame; i++)
							{
								container.TableValue[i].Flags = Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit.CLEAR;

								Library_SpriteStudio6.Data.Animation.Attribute.Importer.Inheritance.ValueGetBoolOR(	out valueAttribute,
																													listKeyData[0],
																													i,
																													true
																												);
								container.TableValue[i].Flags |= (true == valueAttribute) ? Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit.HIDE : Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit.CLEAR;

								Library_SpriteStudio6.Data.Animation.Attribute.Importer.Inheritance.ValueGetBoolToggle(	out valueAttribute,
																														listKeyData[1],
																														i
																													);
								container.TableValue[i].Flags |= (true == valueAttribute) ? Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit.FLIP_X : Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit.CLEAR;

								Library_SpriteStudio6.Data.Animation.Attribute.Importer.Inheritance.ValueGetBoolToggle(	out valueAttribute,
																														listKeyData[2],
																														i
																													);
								container.TableValue[i].Flags |= (true == valueAttribute) ? Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit.FLIP_Y : Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit.CLEAR;

								Library_SpriteStudio6.Data.Animation.Attribute.Importer.Inheritance.ValueGetBoolToggle(	out valueAttribute,
																														listKeyData[3],
																														i
																													);
								container.TableValue[i].Flags |= (true == valueAttribute) ? Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit.FLIP_TEXTURE_Y : Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit.CLEAR;

								Library_SpriteStudio6.Data.Animation.Attribute.Importer.Inheritance.ValueGetBoolToggle(	out valueAttribute,
																														listKeyData[4],
																														i
																													);
								container.TableValue[i].Flags |= (true == valueAttribute) ? Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit.FLIP_TEXTURE_Y : Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit.CLEAR;

								container.TableValue[i].Flags |= (null != tableOrderDraw)
																	? (Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit)tableOrderDraw[i] & Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit.ID_PARTS_DRAWNEXT
																	: Library_SpriteStudio6.Data.Animation.Attribute.Status.FlagBit.ID_PARTS_DRAWNEXT;	/* -1 */
							}
							return(true);
						}
						#endregion Functions
					}

					public class InterfaceFunctionCell : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerCell
					{
						/* ----------------------------------------------- Functions */
						#region Functions
						public bool ValueGet(	ref Library_SpriteStudio6.Data.Animation.Attribute.Cell outValue,
												ref int outFrameKey,
												Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerCell container,
												ref Library_SpriteStudio6.Data.Animation.PackAttribute.ArgumentContainer argument
											)
						{
							return(Library_SpriteStudio6.Data.Animation.PackAttribute.StandardUncompressed.ValueGet(ref outValue, ref outFrameKey, argument.Frame, container.TableValue));
						}

						public bool Pack(	Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerCell container,
											string nameAttribute,
											int countFrame,
											Library_SpriteStudio6.Data.Animation.Parts.FlagBitStatus flagStatusParts,
											int[] tableOrderDraw,
											params Library_SpriteStudio6.Data.Animation.Attribute.Importer.AttributeCell[] listKeyData
										)
						{	/* MEMO: "ListKeyData.Length" is always 1 *//* MEMO: No inheritance is related to attribute stored in this type. */
							container.TableCodeValue = new Library_SpriteStudio6.Data.Animation.PackAttribute.CodeValueContainer[0];

							if(0 >= listKeyData[0].CountGetKey())
							{
								container.TableValue = new Library_SpriteStudio6.Data.Animation.Attribute.Cell[0];
								return(true);
							}

							container.TableValue = new Library_SpriteStudio6.Data.Animation.Attribute.Cell[countFrame];
							for(int i=0; i<countFrame; i++)
							{
								listKeyData[0].ValueGet(out container.TableValue[i], i);
							}
							return(true);
						}
						#endregion Functions
					}

					public class InterfaceFunctionColorBlend : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerColorBlend
					{
						/* ----------------------------------------------- Functions */
						#region Functions
						public bool ValueGet(	ref Library_SpriteStudio6.Data.Animation.Attribute.ColorBlend outValue,
												ref int outFrameKey,
												Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerColorBlend container,
												ref Library_SpriteStudio6.Data.Animation.PackAttribute.ArgumentContainer argument
											)
						{
							return(Library_SpriteStudio6.Data.Animation.PackAttribute.StandardUncompressed.ValueGet(ref outValue, ref outFrameKey, argument.Frame, container.TableValue));
						}

						public bool Pack(	Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerColorBlend container,
											string nameAttribute,
											int countFrame,
											Library_SpriteStudio6.Data.Animation.Parts.FlagBitStatus flagStatusParts,
											int[] tableOrderDraw,
											params Library_SpriteStudio6.Data.Animation.Attribute.Importer.AttributeColorBlend[] listKeyData
										)
						{	/* MEMO: "ListKeyData.Length" is always 1 *//* MEMO: No inheritance is related to attribute stored in this type. */
							container.TableCodeValue = new Library_SpriteStudio6.Data.Animation.PackAttribute.CodeValueContainer[0];

							if(0 >= listKeyData[0].CountGetKey())
							{
								container.TableValue = new Library_SpriteStudio6.Data.Animation.Attribute.ColorBlend[0];
								return(true);
							}

							container.TableValue = new Library_SpriteStudio6.Data.Animation.Attribute.ColorBlend[countFrame];
							for(int i=0; i<countFrame; i++)
							{
								listKeyData[0].ValueGet(out container.TableValue[i], i);
							}
							return(true);
						}
						#endregion Functions
					}

					public class InterfaceFunctionVertexCorrection : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerVertexCorrection
					{
						/* ----------------------------------------------- Functions */
						#region Functions
						public bool ValueGet(	ref Library_SpriteStudio6.Data.Animation.Attribute.VertexCorrection outValue,
												ref int outFrameKey,
												Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerVertexCorrection container,
												ref Library_SpriteStudio6.Data.Animation.PackAttribute.ArgumentContainer argument
											)
						{
							return(Library_SpriteStudio6.Data.Animation.PackAttribute.StandardUncompressed.ValueGet(ref outValue, ref outFrameKey, argument.Frame, container.TableValue));
						}

						public bool Pack(	Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerVertexCorrection container,
											string nameAttribute,
											int countFrame,
											Library_SpriteStudio6.Data.Animation.Parts.FlagBitStatus flagStatusParts,
											int[] tableOrderDraw,
											params Library_SpriteStudio6.Data.Animation.Attribute.Importer.AttributeVertexCorrection[] listKeyData
										)
						{	/* MEMO: "ListKeyData.Length" is always 1 *//* MEMO: No inheritance is related to attribute stored in this type. */
							container.TableCodeValue = new Library_SpriteStudio6.Data.Animation.PackAttribute.CodeValueContainer[0];

							if(0 >= listKeyData[0].CountGetKey())
							{
								container.TableValue = new Library_SpriteStudio6.Data.Animation.Attribute.VertexCorrection[0];
								return(true);
							}

							container.TableValue = new Library_SpriteStudio6.Data.Animation.Attribute.VertexCorrection[countFrame];
							for(int i=0; i<countFrame; i++)
							{
								listKeyData[0].ValueGet(out container.TableValue[i], i);
							}
							return(true);
						}
						#endregion Functions
					}

					/* MEMO: Not Support */
//					public class InterfaceFunctionUserData : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerUserData
					/* MEMO: Not Support */
//					public class InterfaceFunctionInstance : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerInstance
					/* MEMO: Not Support */
//					public class InterfaceFunctionEffect : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerEffect

					public class InterfaceFunctionCoordinateFix : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerCoordinateFix
					{
						/* ----------------------------------------------- Functions */
						#region Functions
						public bool ValueGet(	ref Library_SpriteStudio6.Data.Animation.Attribute.CoordinateFix outValue,
												ref int outFrameKey,
												Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerCoordinateFix container,
												ref Library_SpriteStudio6.Data.Animation.PackAttribute.ArgumentContainer argument
											)
						{
							return(Library_SpriteStudio6.Data.Animation.PackAttribute.StandardUncompressed.ValueGet(ref outValue, ref outFrameKey, argument.Frame, container.TableValue));
						}

						public bool Pack(	Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerCoordinateFix container,
											string nameAttribute,
											int countFrame,
											Library_SpriteStudio6.Data.Animation.Parts.FlagBitStatus flagStatusParts,
											int[] tableOrderDraw,
											params Library_SpriteStudio6.Data.Animation.Attribute.Importer.AttributeCoordinateFix[] listKeyData
										)
						{	/* MEMO: "ListKeyData.Length" is always 1 *//* MEMO: No inheritance is related to attribute stored in this type. */
							container.TableCodeValue = new Library_SpriteStudio6.Data.Animation.PackAttribute.CodeValueContainer[0];

							if(0 >= listKeyData[0].CountGetKey())
							{
								container.TableValue = new Library_SpriteStudio6.Data.Animation.Attribute.CoordinateFix[0];
								return(true);
							}

							container.TableValue = new Library_SpriteStudio6.Data.Animation.Attribute.CoordinateFix[countFrame];
							for(int i=0; i<countFrame; i++)
							{
								listKeyData[0].ValueGet(out container.TableValue[i], i);
							}
							return(true);
						}
						#endregion Functions
					}

					public class InterfaceFunctionColorBlendFix : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerColorBlendFix
					{
						/* ----------------------------------------------- Functions */
						#region Functions
						public bool ValueGet(	ref Library_SpriteStudio6.Data.Animation.Attribute.ColorBlendFix outValue,
												ref int outFrameKey,
												Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerColorBlendFix container,
												ref Library_SpriteStudio6.Data.Animation.PackAttribute.ArgumentContainer argument
											)
						{
							return(Library_SpriteStudio6.Data.Animation.PackAttribute.StandardUncompressed.ValueGet(ref outValue, ref outFrameKey, argument.Frame, container.TableValue));
						}

						public bool Pack(	Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerColorBlendFix container,
											string nameAttribute,
											int countFrame,
											Library_SpriteStudio6.Data.Animation.Parts.FlagBitStatus flagStatusParts,
											int[] tableOrderDraw,
											params Library_SpriteStudio6.Data.Animation.Attribute.Importer.AttributeColorBlendFix[] listKeyData
										)
						{	/* MEMO: "ListKeyData.Length" is always 1 *//* MEMO: No inheritance is related to attribute stored in this type. */
							container.TableCodeValue = new Library_SpriteStudio6.Data.Animation.PackAttribute.CodeValueContainer[0];

							if(0 >= listKeyData[0].CountGetKey())
							{
								container.TableValue = new Library_SpriteStudio6.Data.Animation.Attribute.ColorBlendFix[0];
								return(true);
							}

							container.TableValue = new Library_SpriteStudio6.Data.Animation.Attribute.ColorBlendFix[countFrame];
							for(int i=0; i<countFrame; i++)
							{
								listKeyData[0].ValueGet(out container.TableValue[i], i);
							}
							return(true);
						}
						#endregion Functions
					}

					public class InterfaceFunctionUVFix : Library_SpriteStudio6.Data.Animation.PackAttribute.InterfaceContainerUVFix
					{
						/* ----------------------------------------------- Functions */
						#region Functions
						public bool ValueGet(	ref Library_SpriteStudio6.Data.Animation.Attribute.UVFix outValue,
												ref int outFrameKey,
												Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerUVFix container,
												ref Library_SpriteStudio6.Data.Animation.PackAttribute.ArgumentContainer argument
											)
						{
							return(Library_SpriteStudio6.Data.Animation.PackAttribute.StandardUncompressed.ValueGet(ref outValue, ref outFrameKey, argument.Frame, container.TableValue));
						}

						public bool Pack(	Library_SpriteStudio6.Data.Animation.PackAttribute.ContainerUVFix container,
											string nameAttribute,
											int countFrame,
											Library_SpriteStudio6.Data.Animation.Parts.FlagBitStatus flagStatusParts,
											int[] tableOrderDraw,
											params Library_SpriteStudio6.Data.Animation.Attribute.Importer.AttributeUVFix[] listKeyData
										)
						{	/* MEMO: "ListKeyData.Length" is always 1 *//* MEMO: No inheritance is related to attribute stored in this type. */
							container.TableCodeValue = new Library_SpriteStudio6.Data.Animation.PackAttribute.CodeValueContainer[0];

							if(0 >= listKeyData[0].CountGetKey())
							{
								container.TableValue = new Library_SpriteStudio6.Data.Animation.Attribute.UVFix[0];
								return(true);
							}

							container.TableValue = new Library_SpriteStudio6.Data.Animation.Attribute.UVFix[countFrame];
							for(int i=0; i<countFrame; i++)
							{
								listKeyData[0].ValueGet(out container.TableValue[i], i);
							}
							return(true);
						}
						#endregion Functions
					}
					#endregion Classes, Structs & Interfaces

					/* ----------------------------------------------- Functions */
					#region Functions
					public static bool ValueGet<_Type>(	ref _Type outValue,
														ref int outFrameKey,
														int frame,
														_Type[] tableValue
													)
						where _Type : struct
					{
						if((0 > frame) || (tableValue.Length <= frame))
						{
							return(false);
						}
						if(outFrameKey == frame)
						{
							return(false);
						}

						outValue = tableValue[frame];
						outFrameKey = frame;
						return(true);
					}
					#endregion Functions
				}
				#endregion Classes, Structs & Interfaces
			}
		}
	}
}