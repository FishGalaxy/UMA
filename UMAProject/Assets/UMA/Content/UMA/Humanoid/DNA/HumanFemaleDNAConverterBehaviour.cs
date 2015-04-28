using UnityEngine;
using System.Collections;
using UMA;

/// <summary>
/// Human female DNA converter behaviour.
/// </summary>
/// <remarks>
/// Although intended for Humans this DNA converter includes ranges
/// far outside Human norms and can also be used for other Humanoid charatcers
/// such as Elves, Giants, Halflings, et al.
/// </remarks>
public class HumanFemaleDNAConverterBehaviour : HumanoidDNAConverterBehaviour
{
	public HumanFemaleDNAConverterBehaviour()
	{
		this.ApplyDnaAction = UpdateUMAFemaleDNABones;
		this.DNAType = typeof(UMADnaHumanoid);
	}

	/// <summary>
	/// Adjusts a skeleton to reflect the DNA values from UMA character data.
	/// </summary>
	/// <remarks>
	/// This will set the postion, rotation, and scale of the various adjustment
	/// bones used by the UMA human rigs to generate a unique character shape.
	/// Also calculates a somewhat realistic mass for the character and the
	/// height and radius of their default collider.
	/// </remarks>
	/// <param name="umaData">UMA data.</param>
	/// <param name="skeleton">Skeleton.</param>
	public static void UpdateUMAFemaleDNABones(UMAData umaData, UMASkeleton skeleton)
	{
		var umaDna = umaData.GetDna<UMADnaHumanoid>();
		skeleton.SetScale(headAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 1, 1),
			Mathf.Clamp(1 + (umaDna.headWidth - 0.5f) * 0.30f, 0.5f, 1.6f),
			Mathf.Clamp(1 , 1, 1)));
		
		//umaData.boneList["HeadAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 1, 1),
		//Mathf.Clamp(1 + (umaDna.headWidth - 0.5f) * 0.30f, 0.5f, 1.6f),
		//Mathf.Clamp(1 , 1, 1));
		
		skeleton.SetScale(neckAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.neckThickness - 0.5f) * 0.80f, 0.5f, 1.6f),
			Mathf.Clamp(1 + (umaDna.neckThickness - 0.5f) * 1.2f, 0.5f, 1.6f)));
		
		//umaData.boneList["NeckAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.neckThickness - 0.5f) * 0.80f, 0.5f, 1.6f),
		//Mathf.Clamp(1 + (umaDna.neckThickness - 0.5f) * 1.2f, 0.5f, 1.6f));
		
		skeleton.SetScale(leftOuterBreastHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.breastSize - 0.5f) * 1.50f + (umaDna.upperWeight - 0.5f) * 0.10f, 0.6f, 1.5f),
			Mathf.Clamp(1 + (umaDna.breastSize - 0.5f) * 1.50f + (umaDna.upperWeight - 0.5f) * 0.10f, 0.6f, 1.5f),
			Mathf.Clamp(1 + (umaDna.breastSize - 0.5f) * 1.50f + (umaDna.upperWeight - 0.5f) * 0.10f, 0.6f, 1.5f)));
		skeleton.SetScale(rightOuterBreastHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.breastSize - 0.5f) * 1.50f + (umaDna.upperWeight - 0.5f) * 0.10f, 0.6f, 1.5f),
			Mathf.Clamp(1 + (umaDna.breastSize - 0.5f) * 1.50f + (umaDna.upperWeight - 0.5f) * 0.10f, 0.6f, 1.5f),
			Mathf.Clamp(1 + (umaDna.breastSize - 0.5f) * 1.50f + (umaDna.upperWeight - 0.5f) * 0.10f, 0.6f, 1.5f)));
		
		//umaData.boneList["LeftOuterBreast"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1 + (umaDna.breastSize - 0.5f) * 1.50f + (umaDna.upperWeight - 0.5f) * 0.10f, 0.6f, 1.5f),
		//Mathf.Clamp(1 + (umaDna.breastSize - 0.5f) * 1.50f + (umaDna.upperWeight - 0.5f) * 0.10f, 0.6f, 1.5f),
		//Mathf.Clamp(1 + (umaDna.breastSize - 0.5f) * 1.50f + (umaDna.upperWeight - 0.5f) * 0.10f, 0.6f, 1.5f));
		//umaData.boneList["RightOuterBreast"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1 + (umaDna.breastSize - 0.5f) * 1.50f + (umaDna.upperWeight - 0.5f) * 0.10f, 0.6f, 1.5f),
		//Mathf.Clamp(1 + (umaDna.breastSize - 0.5f) * 1.50f + (umaDna.upperWeight - 0.5f) * 0.10f, 0.6f, 1.5f),
		//Mathf.Clamp(1 + (umaDna.breastSize - 0.5f) * 1.50f + (umaDna.upperWeight - 0.5f) * 0.10f, 0.6f, 1.5f));
		
		skeleton.SetScale(leftEyeHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.eyeSize - 0.5f) * 0.3f , 0.7f, 1.4f),
			Mathf.Clamp(1 + (umaDna.eyeSize - 0.5f) * 0.3f , 0.7f, 1.4f),
			Mathf.Clamp(1 + (umaDna.eyeSize - 0.5f) * 0.3f , 0.7f, 1.4f)));
		skeleton.SetScale(rightEyeHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.eyeSize - 0.5f) * 0.3f , 0.7f, 1.4f),
			Mathf.Clamp(1 + (umaDna.eyeSize - 0.5f) * 0.3f , 0.7f, 1.4f),
			Mathf.Clamp(1 + (umaDna.eyeSize - 0.5f) * 0.3f , 0.7f, 1.4f)));
		
		//umaData.boneList["LeftEye"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1 + (umaDna.eyeSize - 0.5f) * 0.3f , 0.7f, 1.4f),
		//Mathf.Clamp(1 + (umaDna.eyeSize - 0.5f) * 0.3f , 0.7f, 1.4f),
		//Mathf.Clamp(1 + (umaDna.eyeSize - 0.5f) * 0.3f , 0.7f, 1.4f));
		//umaData.boneList["RightEye"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1 + (umaDna.eyeSize - 0.5f) * 0.3f , 0.7f, 1.4f),
		//Mathf.Clamp(1 + (umaDna.eyeSize - 0.5f) * 0.3f , 0.7f, 1.4f),
		//Mathf.Clamp(1 + (umaDna.eyeSize - 0.5f) * 0.3f , 0.7f, 1.4f));     

		skeleton.SetRotation(leftEyeAdjustHash,
		                     Quaternion.Euler(new Vector3((umaDna.eyeRotation - 0.5f) * 20, 0, 0)));
		skeleton.SetRotation(rightEyeAdjustHash,
		                     Quaternion.Euler(new Vector3(-(umaDna.eyeRotation - 0.5f) * 20, 0, 0)));
		
		//umaData.boneList["LeftEye"].boneTransform.localEulerAngles = new Vector3((umaDna.eyeRotation - 0.5f) * 20, -90, -180);
		//umaData.boneList["RightEye"].boneTransform.localEulerAngles = new Vector3(-(umaDna.eyeRotation - 0.5f) * 20, -90, -180);
		
		skeleton.SetScale(spine1AdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.10f + (umaDna.upperMuscle - 0.5f) * 0.15f, 0.75f, 1.10f),
			Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.10f + (umaDna.upperMuscle - 0.5f) * 0.25f, 0.85f, 1.00f)));
		
		//umaData.boneList["Spine1Adjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.10f + (umaDna.upperMuscle - 0.5f) * 0.15f, 0.75f, 1.10f),
		//Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.10f + (umaDna.upperMuscle - 0.5f) * 0.25f, 0.85f, 1.00f));
		
		skeleton.SetScale(spineAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.25f + (umaDna.upperMuscle - 0.5f) * 0.25f, 0.85f, 1.350f),
			Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.25f + (umaDna.upperMuscle - 0.5f) * 0.25f, 0.85f, 1.450f)));
		
		//umaData.boneList["SpineAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.25f + (umaDna.upperMuscle - 0.5f) * 0.25f, 0.85f, 1.350f),
		//Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.25f + (umaDna.upperMuscle - 0.5f) * 0.25f, 0.85f, 1.450f));
		
		skeleton.SetScale(lowerBackBellyHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.belly - 0.5f) * 1.75f, 0.35f, 1.75f),
			Mathf.Clamp(1 + (umaDna.waist - 0.5f) * 1.75f, 0.35f, 1.75f),
			Mathf.Clamp(1 + (umaDna.belly - 0.5f) * 3.00f, 0.35f, 3.0f)));
		
		//umaData.boneList["LowerBackBelly"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1 + (umaDna.belly - 0.5f) * 1.75f, 0.35f, 1.75f),
		//Mathf.Clamp(1 + (umaDna.waist - 0.5f) * 1.75f, 0.35f, 1.75f),
		//Mathf.Clamp(1 + (umaDna.belly - 0.5f) * 3.00f, 0.35f, 3.0f));
		
		skeleton.SetScale(lowerBackAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.25f + (umaDna.lowerWeight - 0.5f) * 0.15f, 0.85f, 1.5f),
			Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.25f + (umaDna.lowerWeight - 0.5f) * 0.15f, 0.85f, 1.5f),
			Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.25f + (umaDna.lowerWeight - 0.5f) * 0.15f, 0.85f, 1.5f)));
		
		//umaData.boneList["LowerBackAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.25f + (umaDna.lowerWeight - 0.5f) * 0.15f, 0.85f, 1.5f),
		//Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.25f + (umaDna.lowerWeight - 0.5f) * 0.15f, 0.85f, 1.5f),
		//Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.25f + (umaDna.lowerWeight - 0.5f) * 0.15f, 0.85f, 1.5f));
		
		skeleton.SetScale(leftTrapeziusHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.upperMuscle - 0.5f) * 1.35f, 0.65f, 1.35f),
			Mathf.Clamp(1 + (umaDna.upperMuscle - 0.5f) * 1.35f, 0.65f, 1.35f),
			Mathf.Clamp(1 + (umaDna.upperMuscle - 0.5f) * 1.35f, 0.65f, 1.35f)));
		skeleton.SetScale(rightTrapeziusHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.upperMuscle - 0.5f) * 1.35f, 0.65f, 1.35f),
			Mathf.Clamp(1 + (umaDna.upperMuscle - 0.5f) * 1.35f, 0.65f, 1.35f),
			Mathf.Clamp(1 + (umaDna.upperMuscle - 0.5f) * 1.35f, 0.65f, 1.35f)));
		
		//umaData.boneList["LeftTrapezius"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1 + (umaDna.upperMuscle - 0.5f) * 1.35f, 0.65f, 1.35f),
		//Mathf.Clamp(1 + (umaDna.upperMuscle - 0.5f) * 1.35f, 0.65f, 1.35f),
		//Mathf.Clamp(1 + (umaDna.upperMuscle - 0.5f) * 1.35f, 0.65f, 1.35f));
		//umaData.boneList["RightTrapezius"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1 + (umaDna.upperMuscle - 0.5f) * 1.35f, 0.65f, 1.35f),
		//Mathf.Clamp(1 + (umaDna.upperMuscle - 0.5f) * 1.35f, 0.65f, 1.35f),
		//Mathf.Clamp(1 + (umaDna.upperMuscle - 0.5f) * 1.35f, 0.65f, 1.35f));
		
		skeleton.SetScale(leftArmAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.armWidth - 0.5f) * 0.65f, 0.65f, 1.65f),
			Mathf.Clamp(1 + (umaDna.armWidth - 0.5f) * 0.65f, 0.65f, 1.65f)));
		skeleton.SetScale(rightArmAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.armWidth - 0.5f) * 0.65f, 0.65f, 1.65f),
			Mathf.Clamp(1 + (umaDna.armWidth - 0.5f) * 0.65f, 0.65f, 1.65f)));
		
		//umaData.boneList["LeftArmAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.armWidth - 0.5f) * 0.65f, 0.65f, 1.65f),
		//Mathf.Clamp(1 + (umaDna.armWidth - 0.5f) * 0.65f, 0.65f, 1.65f));
		//umaData.boneList["RightArmAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.armWidth - 0.5f) * 0.65f, 0.65f, 1.65f),
		//Mathf.Clamp(1 + (umaDna.armWidth - 0.5f) * 0.65f, 0.65f, 1.65f));
		
		skeleton.SetScale(leftForeArmAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.65f, 0.75f, 1.25f),
			Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.65f, 0.75f, 1.25f)));
		skeleton.SetScale(rightForeArmAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.65f, 0.75f, 1.25f),
			Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.65f, 0.75f, 1.25f)));
		
		//umaData.boneList["LeftForeArmAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.65f, 0.75f, 1.25f),
		//Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.65f, 0.75f, 1.25f));
		//umaData.boneList["RightForeArmAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.65f, 0.75f, 1.25f),
		//Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.65f, 0.75f, 1.25f));
		
		skeleton.SetScale(leftForeArmTwistAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.35f, 0.75f, 1.25f),
			Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.35f, 0.75f, 1.25f)));
		skeleton.SetScale(rightForeArmTwistAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.35f, 0.75f, 1.25f),
			Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.35f, 0.75f, 1.25f)));
		
		//umaData.boneList["LeftForeArmTwistAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.35f, 0.75f, 1.25f),
		//Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.35f, 0.75f, 1.25f));
		//umaData.boneList["RightForeArmTwistAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.35f, 0.75f, 1.25f),
		//Mathf.Clamp(1 + (umaDna.forearmWidth - 0.5f) * 0.35f, 0.75f, 1.25f));
		
		skeleton.SetScale(leftShoulderAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.35f + (umaDna.upperMuscle - 0.5f) * 0.55f, 0.75f, 1.25f),
			Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.35f + (umaDna.upperMuscle - 0.5f) * 0.55f, 0.75f, 1.25f)));
		skeleton.SetScale(rightShoulderAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.35f + (umaDna.upperMuscle - 0.5f) * 0.55f, 0.75f, 1.25f),
			Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.35f + (umaDna.upperMuscle - 0.5f) * 0.55f, 0.75f, 1.25f)));
		
		//umaData.boneList["LeftShoulderAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.35f + (umaDna.upperMuscle - 0.5f) * 0.55f, 0.75f, 1.25f),
		//Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.35f + (umaDna.upperMuscle - 0.5f) * 0.55f, 0.75f, 1.25f));
		//umaData.boneList["RightShoulderAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.35f + (umaDna.upperMuscle - 0.5f) * 0.55f, 0.75f, 1.25f),
		//Mathf.Clamp(1 + (umaDna.upperWeight - 0.5f) * 0.35f + (umaDna.upperMuscle - 0.5f) * 0.55f, 0.75f, 1.25f));
		
		skeleton.SetScale(leftUpLegAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.65f + (umaDna.lowerMuscle - 0.5f) * 0.15f - (umaDna.legsSize - 0.5f), 0.45f, 1.35f),
			Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.65f + (umaDna.lowerMuscle - 0.5f) * 0.15f - (umaDna.legsSize - 0.5f), 0.45f, 1.35f)));
		skeleton.SetScale(rightUpLegAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.65f + (umaDna.lowerMuscle - 0.5f) * 0.15f - (umaDna.legsSize - 0.5f), 0.45f, 1.35f),
			Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.65f + (umaDna.lowerMuscle - 0.5f) * 0.15f - (umaDna.legsSize - 0.5f), 0.45f, 1.35f)));
		
		//umaData.boneList["LeftUpLegAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.65f + (umaDna.lowerMuscle - 0.5f) * 0.15f - (umaDna.legsSize - 0.5f), 0.45f, 1.35f),
		//Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.65f + (umaDna.lowerMuscle - 0.5f) * 0.15f - (umaDna.legsSize - 0.5f), 0.45f, 1.35f));
		//umaData.boneList["RightUpLegAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.65f + (umaDna.lowerMuscle - 0.5f) * 0.15f - (umaDna.legsSize - 0.5f), 0.45f, 1.35f),
		//Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.65f + (umaDna.lowerMuscle - 0.5f) * 0.15f - (umaDna.legsSize - 0.5f), 0.45f, 1.35f));
		
		skeleton.SetScale(leftLegAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.15f + (umaDna.lowerMuscle - 0.5f) * 0.95f - (umaDna.legsSize - 0.5f), 0.65f, 1.45f),
			Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.15f + (umaDna.lowerMuscle - 0.5f) * 0.75f - (umaDna.legsSize - 0.5f), 0.65f, 1.45f)));
		skeleton.SetScale(rightLegAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.15f + (umaDna.lowerMuscle - 0.5f) * 0.95f - (umaDna.legsSize - 0.5f), 0.65f, 1.45f),
			Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.15f + (umaDna.lowerMuscle - 0.5f) * 0.75f - (umaDna.legsSize - 0.5f), 0.65f, 1.45f)));
		
		//umaData.boneList["LeftLegAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.15f + (umaDna.lowerMuscle - 0.5f) * 0.95f - (umaDna.legsSize - 0.5f), 0.65f, 1.45f),
		//Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.15f + (umaDna.lowerMuscle - 0.5f) * 0.75f - (umaDna.legsSize - 0.5f), 0.65f, 1.45f));
		//umaData.boneList["RightLegAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.15f + (umaDna.lowerMuscle - 0.5f) * 0.95f - (umaDna.legsSize - 0.5f), 0.65f, 1.45f),
		//Mathf.Clamp(1 + (umaDna.lowerWeight - 0.5f) * 0.15f + (umaDna.lowerMuscle - 0.5f) * 0.75f - (umaDna.legsSize - 0.5f), 0.65f, 1.45f));
		
		skeleton.SetScale(leftGluteusHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.gluteusSize - 0.5f) * 1.35f , 0.25f, 2.35f),
			Mathf.Clamp(1 + (umaDna.gluteusSize - 0.5f) * 1.35f , 0.25f, 2.35f),
			Mathf.Clamp(1 + (umaDna.gluteusSize - 0.5f) * 1.35f , 0.25f, 2.35f)));
		skeleton.SetScale(rightGluteusHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.gluteusSize - 0.5f) * 1.35f , 0.25f, 2.35f),
			Mathf.Clamp(1 + (umaDna.gluteusSize - 0.5f) * 1.35f , 0.25f, 2.35f),
			Mathf.Clamp(1 + (umaDna.gluteusSize - 0.5f) * 1.35f , 0.25f, 2.35f)));
		
		//umaData.boneList["LeftGluteus"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1 + (umaDna.gluteusSize - 0.5f) * 1.35f , 0.25f, 2.35f),
		//Mathf.Clamp(1 + (umaDna.gluteusSize - 0.5f) * 1.35f , 0.25f, 2.35f),
		//Mathf.Clamp(1 + (umaDna.gluteusSize - 0.5f) * 1.35f , 0.25f, 2.35f));
		//umaData.boneList["RightGluteus"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1 + (umaDna.gluteusSize - 0.5f) * 1.35f , 0.25f, 2.35f),
		//Mathf.Clamp(1 + (umaDna.gluteusSize - 0.5f) * 1.35f , 0.25f, 2.35f),
		//Mathf.Clamp(1 + (umaDna.gluteusSize - 0.5f) * 1.35f , 0.25f, 2.35f));
		
		skeleton.SetScale(leftEarAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.earsSize - 0.5f) * 1.0f, 0.75f, 1.5f),
			Mathf.Clamp(1 + (umaDna.earsSize - 0.5f) * 1.0f, 0.75f, 1.5f),
			Mathf.Clamp(1 + (umaDna.earsSize - 0.5f) * 1.0f, 0.75f, 1.5f)));
		skeleton.SetScale(rightEarAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.earsSize - 0.5f) * 1.0f, 0.75f, 1.5f),
			Mathf.Clamp(1 + (umaDna.earsSize - 0.5f) * 1.0f, 0.75f, 1.5f),
			Mathf.Clamp(1 + (umaDna.earsSize - 0.5f) * 1.0f, 0.75f, 1.5f)));
		
		//umaData.boneList["LeftEarAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1 + (umaDna.earsSize - 0.5f) * 1.0f, 0.75f, 1.5f),
		//Mathf.Clamp(1 + (umaDna.earsSize - 0.5f) * 1.0f, 0.75f, 1.5f),
		//Mathf.Clamp(1 + (umaDna.earsSize - 0.5f) * 1.0f, 0.75f, 1.5f));
		//umaData.boneList["RightEarAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1 + (umaDna.earsSize - 0.5f) * 1.0f, 0.75f, 1.5f),
		//Mathf.Clamp(1 + (umaDna.earsSize - 0.5f) * 1.0f, 0.75f, 1.5f),
		//Mathf.Clamp(1 + (umaDna.earsSize - 0.5f) * 1.0f, 0.75f, 1.5f));
		
		skeleton.SetPosition(leftEarAdjustHash,
		                     skeleton.GetPosition(leftEarAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.headWidth - 0.5f) * -0.01f, -0.01f, 0.01f),
			Mathf.Clamp(0 + (umaDna.headWidth - 0.5f) * -0.03f, -0.03f, 0.03f),
			Mathf.Clamp(0 + (umaDna.earsPosition - 0.5f) * 0.02f, -0.02f, 0.02f)));
		skeleton.SetPosition(rightEarAdjustHash,
		                     skeleton.GetPosition(rightEarAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.headWidth - 0.5f) * -0.01f, -0.01f, 0.01f),
			Mathf.Clamp(0 + (umaDna.headWidth - 0.5f) * 0.03f, -0.03f, 0.03f),
			Mathf.Clamp(0 + (umaDna.earsPosition - 0.5f) * 0.02f, -0.02f, 0.02f)));
		
		skeleton.SetRotation(leftEarAdjustHash,
		                     Quaternion.Euler(new Vector3(
			Mathf.Clamp(0, -30, 80),
			Mathf.Clamp(0, -30, 80),
			Mathf.Clamp((umaDna.earsRotation - 0.5f) * 40, -15, 40))));
		skeleton.SetRotation(rightEarAdjustHash,
		                     Quaternion.Euler(new Vector3(
			Mathf.Clamp(0, -30, 80),
			Mathf.Clamp(0, -30, 80),
			Mathf.Clamp((umaDna.earsRotation - 0.5f) * -40, -40, 15))));
		
		skeleton.SetScale(noseBaseAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.noseSize - 0.5f) * 1.5f, 0.4f, 3.0f),
			Mathf.Clamp(1 + (umaDna.noseSize - 0.5f) * 0.15f + (umaDna.noseWidth - 0.5f) * 1.0f, 0.25f, 3.0f),
			Mathf.Clamp(1 + (umaDna.noseSize - 0.5f) * 0.15f + (umaDna.noseFlatten - 0.5f) * 0.75f, 0.25f, 3.0f)));
		skeleton.SetScale(noseMiddleAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.noseCurve - 0.5f) * 1.9f + (umaDna.noseSize - 0.5f) * 1.0f, 0.5f, 3.0f),
			Mathf.Clamp(1 + (umaDna.noseCurve - 0.5f) * 0.15f + (umaDna.noseSize - 0.5f) * 0.25f + (umaDna.noseWidth - 0.5f) * 0.5f, 0.5f, 3.0f),
			Mathf.Clamp(1 + (umaDna.noseCurve - 0.5f) * 0.15f + (umaDna.noseSize - 0.5f) * 0.10f, 0.5f, 3.0f)));
		skeleton.SetRotation(noseBaseAdjustHash,
		                     Quaternion.Euler(new Vector3(
			Mathf.Clamp(0, -30, 80),
			Mathf.Clamp((umaDna.noseInclination - 0.5f) * 60, -60, 30),
			Mathf.Clamp(0, -30, 80))));
		skeleton.SetPosition(noseBaseAdjustHash,
		                     skeleton.GetPosition(noseBaseAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.nosePronounced - 0.5f) * -0.0125f, -0.025f, 0.025f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.nosePosition - 0.5f) * 0.0125f, -0.025f, 0.025f)));
		skeleton.SetPosition(noseMiddleAdjustHash,
		                     skeleton.GetPosition(noseBaseAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.nosePronounced - 0.5f) * -0.006f, -0.012f, 0.012f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.nosePosition - 0.5f) * 0.007f, -0.015f, 0.015f)));
		
		skeleton.SetPosition(leftNoseAdjustHash,
		                     skeleton.GetPosition(leftNoseAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.nosePronounced - 0.5f) * -0.0125f, -0.025f, 0.025f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.nosePosition - 0.5f) * 0.0125f, -0.025f, 0.025f)));
		skeleton.SetPosition(rightNoseAdjustHash,
		                     skeleton.GetPosition(rightNoseAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.nosePronounced - 0.5f) * -0.0125f, -0.025f, 0.025f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.nosePosition - 0.5f) * 0.0125f, -0.025f, 0.025f)));
		
		skeleton.SetPosition(upperLipsAdjustHash,
		                     skeleton.GetPosition(upperLipsAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.nosePosition - 0.5f) * 0.0045f, -0.0045f, 0.0045f)));
		
		skeleton.SetScale(mandibleAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.chinPronounced - 0.5f) * 0.18f, 0.55f, 1.75f),
			Mathf.Clamp(1 + (umaDna.chinSize - 0.5f) * 1.3f, 0.75f, 1.3f),
			Mathf.Clamp(1, 0.4f, 1.5f)));
		skeleton.SetPosition(mandibleAdjustHash,
		                     skeleton.GetPosition(mandibleAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0, -0.0125f, 0.0125f),
			Mathf.Clamp(0, -0.0125f, 0.0125f),
			Mathf.Clamp(0 + (umaDna.chinPosition - 0.5f) * 0.0075f, -0.0075f, 0.0075f)));
		
		skeleton.SetPosition(leftLowMaxilarAdjustHash,
		                     skeleton.GetPosition(leftLowMaxilarAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.jawsSize - 0.5f) * 0.025f, -0.025f, 0.025f),
			Mathf.Clamp(0 + (umaDna.jawsPosition - 0.5f) * 0.03f, -0.03f, 0.03f)));
		skeleton.SetPosition(rightLowMaxilarAdjustHash,
		                     skeleton.GetPosition(rightLowMaxilarAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.jawsSize - 0.5f) * -0.025f, -0.025f, 0.025f),
			Mathf.Clamp(0 + (umaDna.jawsPosition - 0.5f) * 0.03f, -0.03f, 0.03f)));
		
		skeleton.SetScale(leftCheekAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.cheekSize - 0.5f) * 1.05f, 0.35f, 2.05f),
			Mathf.Clamp(1 + (umaDna.cheekSize - 0.5f) * 1.05f, 0.35f, 2.05f),
			Mathf.Clamp(1 + (umaDna.cheekSize - 0.5f) * 1.05f, 0.35f, 2.05f)));
		skeleton.SetScale(rightCheekAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.cheekSize - 0.5f) * 1.05f, 0.35f, 2.05f),
			Mathf.Clamp(1 + (umaDna.cheekSize - 0.5f) * 1.05f, 0.35f, 2.05f),
			Mathf.Clamp(1 + (umaDna.cheekSize - 0.5f) * 1.05f, 0.35f, 2.05f)));
		skeleton.SetPosition(leftCheekAdjustHash,
		                     skeleton.GetPosition(leftCheekAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.cheekPosition - 0.5f) * 0.03f, -0.03f, 0.03f)));
		skeleton.SetPosition(rightCheekAdjustHash,
		                     skeleton.GetPosition(rightCheekAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.cheekPosition - 0.5f) * 0.03f, -0.03f, 0.03f)));
		
		skeleton.SetPosition(leftLowCheekAdjustHash,
		                     skeleton.GetPosition(leftLowCheekAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.lowCheekPronounced - 0.5f) * -0.035f, -0.07f, 0.035f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.lowCheekPosition - 0.5f) * 0.06f, -0.06f, 0.06f)));
		skeleton.SetPosition(rightLowCheekAdjustHash,
		                     skeleton.GetPosition(rightLowCheekAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.lowCheekPronounced - 0.5f) * -0.035f, -0.07f, 0.035f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.lowCheekPosition - 0.5f) * 0.06f, -0.06f, 0.06f)));
		
		skeleton.SetPosition(noseTopAdjustHash,
		                     skeleton.GetPosition(noseTopAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.foreheadSize - 0.5f) * -0.015f, -0.025f, 0.005f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.foreheadPosition - 0.5f) * -0.025f + (umaDna.foreheadSize - 0.5f) * -0.0015f, -0.015f, 0.0025f)));
		
		skeleton.SetPosition(leftEyebrowLowAdjustHash,
		                     skeleton.GetPosition(leftEyebrowLowAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.foreheadSize - 0.5f) * -0.015f, -0.025f, 0.005f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.foreheadPosition - 0.5f) * -0.02f + (umaDna.foreheadSize - 0.5f) * -0.005f, -0.015f, 0.005f)));
		skeleton.SetPosition(leftEyebrowMiddleAdjustHash,
		                     skeleton.GetPosition(leftEyebrowMiddleAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.foreheadSize - 0.5f) * -0.015f, -0.025f, 0.005f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.foreheadPosition - 0.5f) * -0.04f + (umaDna.foreheadSize - 0.5f) * -0.005f, -0.025f, 0.005f)));
		skeleton.SetPosition(leftEyebrowUpAdjustHash,
		                     skeleton.GetPosition(leftEyebrowUpAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.foreheadSize - 0.5f) * -0.015f, -0.025f, 0.005f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.foreheadPosition - 0.5f) * -0.007f + (umaDna.foreheadSize - 0.5f) * -0.005f, -0.010f, 0.005f)));
		
		skeleton.SetPosition(rightEyebrowLowAdjustHash,
		                     skeleton.GetPosition(rightEyebrowLowAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.foreheadSize - 0.5f) * -0.015f, -0.025f, 0.005f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.foreheadPosition - 0.5f) * -0.02f + (umaDna.foreheadSize - 0.5f) * -0.005f, -0.015f, 0.005f)));
		skeleton.SetPosition(rightEyebrowMiddleAdjustHash,
		                     skeleton.GetPosition(rightEyebrowMiddleAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.foreheadSize - 0.5f) * -0.015f, -0.025f, 0.005f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.foreheadPosition - 0.5f) * -0.04f + (umaDna.foreheadSize - 0.5f) * -0.005f, -0.025f, 0.005f)));
		skeleton.SetPosition(rightEyebrowUpAdjustHash,
		                     skeleton.GetPosition(rightEyebrowUpAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0 + (umaDna.foreheadSize - 0.5f) * -0.015f, -0.025f, 0.005f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.foreheadPosition - 0.5f) * -0.007f + (umaDna.foreheadSize - 0.5f) * -0.005f, -0.010f, 0.005f)));
		
		skeleton.SetScale(lipsSuperiorAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.05f, 1.0f, 1.05f),
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.9f, 0.65f, 1.5f),
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.9f, 0.65f, 1.5f)));
		skeleton.SetScale(lipsInferiorAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.05f, 1.0f, 1.05f),
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 1.0f, 0.65f, 1.5f),
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 1.0f, 0.65f, 1.5f)));
		
		skeleton.SetScale(leftLipsSuperiorMiddleAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.05f, 1.0f, 1.05f),
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.9f, 0.65f, 1.5f),
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.9f, 0.65f, 1.5f)));
		skeleton.SetScale(rightLipsSuperiorMiddleAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.05f, 1.0f, 1.05f),
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.9f, 0.65f, 1.5f),
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.9f, 0.65f, 1.5f)));
		skeleton.SetScale(leftLipsInferiorAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.05f, 1.0f, 1.05f),
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.9f, 0.65f, 1.5f),
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.9f, 0.65f, 1.5f)));
		skeleton.SetScale(rightLipsInferiorAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.05f, 1.0f, 1.05f),
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.9f, 0.65f, 1.5f),
			Mathf.Clamp(1 + (umaDna.lipsSize - 0.5f) * 0.9f, 0.65f, 1.5f)));
		
		skeleton.SetPosition(lipsInferiorAdjustHash,
		                     skeleton.GetPosition(lipsInferiorAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.lipsSize - 0.5f) * -0.008f, -0.1f, 0.1f)));
		
		skeleton.SetPosition(leftLipsAdjustHash,
		                     skeleton.GetPosition(leftLipsAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.mouthSize - 0.5f) * 0.03f, -0.02f, 0.005f),
			Mathf.Clamp(0, -0.05f, 0.05f)));
		skeleton.SetPosition(rightLipsAdjustHash,
		                     skeleton.GetPosition(rightLipsAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.mouthSize - 0.5f) * -0.03f, -0.005f, 0.02f),
			Mathf.Clamp(0, -0.05f, 0.05f)));
		
		skeleton.SetPosition(leftLipsSuperiorMiddleAdjustHash,
		                     skeleton.GetPosition(leftLipsSuperiorMiddleAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.mouthSize - 0.5f) * 0.007f, -0.02f, 0.005f),
			Mathf.Clamp(0, -0.05f, 0.05f)));
		skeleton.SetPosition(rightLipsSuperiorMiddleAdjustHash,
		                     skeleton.GetPosition(rightLipsSuperiorMiddleAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.mouthSize - 0.5f) * -0.007f, -0.005f, 0.02f),
			Mathf.Clamp(0, -0.05f, 0.05f)));
		skeleton.SetPosition(leftLipsInferiorAdjustHash,
		                     skeleton.GetPosition(leftLipsInferiorAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.mouthSize - 0.5f) * 0.007f, -0.02f, 0.005f),
			Mathf.Clamp(0 + (umaDna.lipsSize - 0.5f) * -0.008f, -0.1f, 0.1f)));
		skeleton.SetPosition(rightLipsInferiorAdjustHash,
		                     skeleton.GetPosition(rightLipsInferiorAdjustHash) +
		                     new Vector3(
			Mathf.Clamp(0, -0.05f, 0.05f),
			Mathf.Clamp(0 + (umaDna.mouthSize - 0.5f) * -0.007f, -0.005f, 0.02f),
			Mathf.Clamp(0 + (umaDna.lipsSize - 0.5f) * -0.008f, -0.1f, 0.1f)));
		
		
		////Bone structure change
		float overallScale = 0.81f + (umaDna.height - 0.5f) * 1.0f + (umaDna.legsSize - 0.5f) * 1.0f;
		overallScale = Mathf.Clamp(overallScale, 0.4f, 1.8f);
		skeleton.SetScale(positionHash, new Vector3(overallScale, overallScale, overallScale));

		skeleton.SetPosition(positionHash,
		                     skeleton.GetPosition(positionHash) +
		                     new Vector3(
			Mathf.Clamp((umaDna.feetSize - 0.5f) * -0.27f, -0.15f, 0.0675f),
			Mathf.Clamp(0, -10, 10),
			Mathf.Clamp(0, -10, 10)));
		
		float lowerBackScale = Mathf.Clamp(1 - (umaDna.legsSize - 0.5f) * 1.0f, 0.5f, 3.0f);
		skeleton.SetScale(lowerBackHash, new Vector3(lowerBackScale, lowerBackScale, lowerBackScale));

		skeleton.SetScale(headHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.headSize - 0.5f) * 2.0f, 0.5f, 2),
			Mathf.Clamp(1 + (umaDna.headSize - 0.5f) * 2.0f, 0.5f, 2),
			Mathf.Clamp(1 + (umaDna.headSize - 0.5f) * 2.0f, 0.5f, 2)));
		
		skeleton.SetScale(leftArmHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.armLength - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.armLength - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.armLength - 0.5f) * 2.0f, 0.5f, 2.0f)));
		skeleton.SetScale(rightArmHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.armLength - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.armLength - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.armLength - 0.5f) * 2.0f, 0.5f, 2.0f)));
		
		skeleton.SetScale(leftForeArmHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.forearmLength - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.forearmLength - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.forearmLength - 0.5f) * 2.0f, 0.5f, 2.0f)));
		skeleton.SetScale(rightForeArmHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.forearmLength - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.forearmLength - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.forearmLength - 0.5f) * 2.0f, 0.5f, 2.0f)));
		
		skeleton.SetScale(leftHandHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.handsSize - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.handsSize - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.handsSize - 0.5f) * 2.0f, 0.5f, 2.0f)));
		skeleton.SetScale(rightHandHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.handsSize - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.handsSize - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.handsSize - 0.5f) * 2.0f, 0.5f, 2.0f)));
		
		skeleton.SetScale(leftFootHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.feetSize - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.feetSize - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.feetSize - 0.5f) * 2.0f, 0.5f, 2.0f)));
		skeleton.SetScale(rightFootHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.feetSize - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.feetSize - 0.5f) * 2.0f, 0.5f, 2.0f),
			Mathf.Clamp(1 + (umaDna.feetSize - 0.5f) * 2.0f, 0.5f, 2.0f)));
		
		skeleton.SetPosition(leftUpLegHash,
		                     skeleton.GetPosition(leftUpLegHash) +
		                     new Vector3(
			Mathf.Clamp(0, -10, 10),
			Mathf.Clamp((umaDna.legSeparation - 0.5f) * -0.15f + (umaDna.lowerWeight - 0.5f) * -0.035f + (umaDna.legsSize - 0.5f) * 0.1f, -0.055f, 0.055f),
			Mathf.Clamp(0, -10, 10)));
		skeleton.SetPosition(rightUpLegHash,
		                     skeleton.GetPosition(rightUpLegHash) +
		                     new Vector3(
			Mathf.Clamp(0, -10, 10),
			Mathf.Clamp((umaDna.legSeparation - 0.5f) * 0.15f + (umaDna.lowerWeight - 0.5f) * 0.035f + (umaDna.legsSize - 0.5f) * -0.1f, -0.025f, 0.025f),
			Mathf.Clamp(0, -10, 10)));
		
		skeleton.SetPosition(leftShoulderHash,
		                     skeleton.GetPosition(leftShoulderHash) +
		                     new Vector3(
			Mathf.Clamp(0, -10, 10),
			Mathf.Clamp((umaDna.upperMuscle - 0.5f) * -0.0235f, -0.025f, 0.015f),
			Mathf.Clamp(0, -10, 10)));
		skeleton.SetPosition(rightShoulderHash,
		                     skeleton.GetPosition(rightShoulderHash) +
		                     new Vector3(
			Mathf.Clamp(0, -10, 10),
			Mathf.Clamp((umaDna.upperMuscle - 0.5f) * 0.0235f, -0.015f, 0.025f),
			Mathf.Clamp(0, -10, 10)));
		
		skeleton.SetScale(mandibleHash, 
		                  new Vector3(
			Mathf.Clamp(1 + (umaDna.mandibleSize - 0.5f) * 0.35f, 0.35f, 1.35f),
			Mathf.Clamp(1 + (umaDna.mandibleSize - 0.5f) * 0.35f, 0.35f, 1.35f),
			Mathf.Clamp(1 + (umaDna.mandibleSize - 0.5f) * 0.35f, 0.35f, 1.35f)));

		umaData.characterHeight = overallScale * (0.85f + 1.2f * lowerBackScale);
		umaData.characterRadius = 0.26f * overallScale;
		umaData.characterMass = 42f * overallScale + 28f * umaDna.upperWeight + 22f * umaDna.lowerWeight;
	}
}