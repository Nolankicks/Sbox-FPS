using Sandbox;

public sealed class Viewmodel : Component
{
	[Property] SkinnedModelRenderer weapon { get; set; }
	[Property] SkinnedModelRenderer arms { get; set; }
	[Property] CameraComponent cameraComponent { get; set; }
	protected override void OnUpdate()
	{
		Transform.Position = cameraComponent.Transform.Position;
		Transform.Rotation = cameraComponent.Transform.Rotation;
	}
}
