using Godot;
using System;

public class CameraMove : Camera
{
    float MOVE_SPEED = 1.0f;

    float xVelocity = 0.0f;
    float zVelocity = 0.0f;
    float yVelocity = 0.0f;

    float yCamera_angle = 0.0f;
    float mouse_sensitibity = .2f;

    Vector2 _mouse_position = new Vector2(0.0f, 0.0f);
    float _yaw = 0.0f;
    float _pitch = 0.0f;
    float _total_yaw = 0.0f;
    const float PITCH_LIMIT = 80.0f;
    float _total_pitch = 0.0f;
    private float _smoothness = 0.5f;
    float smoothness {
        get {return _smoothness;}
        set {
            _smoothness = Mathf.Clamp(value, 0.001f, 0.999f);
        }
    }
    Spatial RotateHelper;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        RotateHelper = this.GetParentSpatial();
        Input.SetMouseMode(Input.MouseMode.Captured);
        GD.Print(yCamera_angle);
    }

    public override void _PhysicsProcess(float delta) {
        this.TranslateObjectLocal(new Vector3(xVelocity * delta, yVelocity * delta, zVelocity * delta));
    }

    public override void _Process(float delta) {
        UpdateMouselook();
    }

    private void UpdateMouselook() {
        _mouse_position *= mouse_sensitibity;
        _yaw = _yaw * smoothness + _mouse_position.x * (1.0f - smoothness);
        _pitch = _pitch * smoothness + _mouse_position.y * (1.0f - smoothness);
        _mouse_position = Vector2.Zero;

        
        _pitch = Mathf.Clamp(_pitch, -PITCH_LIMIT - _total_pitch, PITCH_LIMIT - _total_pitch);
        _total_yaw += _yaw;
        _total_pitch += _pitch;


        this.RotateY(-_yaw * .01745f);
        this.RotateObjectLocal(Vector3.Left, _pitch * .01745f);

    }

    public override void _UnhandledInput(InputEvent @event) {
        if(@event is InputEventKey eventKey) {
            if(eventKey.Scancode == (int)KeyList.Escape) {
                GetTree().Quit();
            }
            if(eventKey.Scancode == (int)KeyList.W) {
                zVelocity = eventKey.Pressed ? -MOVE_SPEED : 0f;
            }
            else if(eventKey.Scancode == (int)KeyList.S) {
                zVelocity = eventKey.Pressed ? MOVE_SPEED : 0f;
            }
            else if(eventKey.Scancode == (int)KeyList.A) {
                xVelocity = eventKey.Pressed ? -MOVE_SPEED : 0f;
            }
            else if(eventKey.Scancode == (int)KeyList.D) {
                xVelocity = eventKey.Pressed ? MOVE_SPEED : 0f;
            }
            else if(eventKey.Scancode == (int)KeyList.E) {
                yVelocity = eventKey.Pressed ? MOVE_SPEED : 0f;
            }
            else if(eventKey.Scancode == (int)KeyList.Q) {
                yVelocity = eventKey.Pressed ? -MOVE_SPEED : 0f;
            }
        } else if(@event is InputEventMouseMotion inputEventMouseMotion) {
            _mouse_position = inputEventMouseMotion.Relative;
        }
    }

}
