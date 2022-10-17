// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""53812ee7-afad-4722-aabc-71eab2ac7153"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e9879753-d0c3-45ca-8dff-5e374953df2c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""8dfe8ac0-db90-432c-a86c-e11c0541fae6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""0cc87976-815c-464b-9c29-8fb6e5f91407"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FightState"",
                    ""type"": ""Button"",
                    ""id"": ""dce569a6-a6e3-4b11-bb0f-fc21489f42be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StrongAttack"",
                    ""type"": ""Button"",
                    ""id"": ""03a2367b-4b26-4943-97b6-fdd5180c56c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SoftAttack"",
                    ""type"": ""Button"",
                    ""id"": ""bf68d818-c5f5-4e4d-b51c-71d826290839"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Targeter"",
                    ""type"": ""Button"",
                    ""id"": ""bfe9ff65-a335-4011-8ffb-dee547e53498"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""20f13a5c-a1e5-4daf-8cae-bc929e089e20"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1a009f93-660f-42e3-9c74-c139560954e8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""98047337-363f-4662-9d50-f1da2dabf65f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""50040349-90e7-4c73-b3d8-6a2f8979e6a7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""44ab0403-31cd-4411-b402-1282120883ec"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""a8224353-2ef5-4491-8da0-aea17d15a564"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""97eed0bb-d847-462b-99be-6dfe90d32711"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""124225a5-3476-418a-8340-f3ce3998ebd5"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""03d6598c-5a55-46de-9449-c94f13b9125d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5a48e0f7-fc5a-4d87-a37b-08ae236dfda8"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""9c2a6b46-53e4-4c5e-bee5-ccce9874e5d0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""05f982e7-af90-498f-bfeb-23d3e760451d"",
                    ""path"": ""<HID:: USB Gamepad          >/hat/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4e5feb51-2d19-454d-b19d-df8f215b2b29"",
                    ""path"": ""<HID:: USB Gamepad          >/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""825a4b3e-4e77-4f24-b7c3-fb8c63913e48"",
                    ""path"": ""<HID:: USB Gamepad          >/hat/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b2d8cf63-9bec-4bc5-8d89-1cbe2a8c5136"",
                    ""path"": ""<HID:: USB Gamepad          >/hat/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LStick"",
                    ""id"": ""6cfe2037-7c05-4cf5-b7f1-724c0d59d628"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""70fe074e-1460-4dfb-9402-7281a82b3bdf"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c5ad73d6-ca07-474d-ab9b-a2eaf6bf2300"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7b7fc79d-faf2-425c-8750-fd86904f094e"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a1f8c1bf-7d5c-4abd-bc29-3f7821792952"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""4bb0bc3d-db71-49f4-bcd5-9ee8c29532d1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2d45e5ea-5b29-44aa-a951-000aa39c4cba"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2aed926f-1ae6-412a-a8bc-dde4a0bb773d"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2ffe923b-cf9a-4b3f-b418-56b925cf4bf6"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""350ef872-39b9-4bc9-9a3f-82b7af1d0ce4"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LStick"",
                    ""id"": ""24b0b414-c38f-4ae2-8980-fdce134ee603"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""72d38188-30e8-47a0-aea2-1f4348ee3c9b"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9843fe68-2821-48ce-93b4-b9ca861963ed"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""04de42e2-a9ee-4296-b06c-99d5079790c6"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b03e76f9-7ad7-4595-9775-ea06ee11ef73"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""91836507-e509-49e8-b1a8-c923d417faa3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2f42d0b-7cd0-479f-9267-7cb708c1d4cb"",
                    ""path"": ""<DualShockGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0728a0ef-c7f5-4e74-bc02-4f87ff490d73"",
                    ""path"": ""<DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7719f7d7-964a-4a73-a8fb-939719a69d23"",
                    ""path"": ""<DualShockGamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ac2f9bde-f21f-4139-be69-91a47a6afcd2"",
                    ""path"": ""<DualShockGamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""dee1ff6f-f626-4723-9093-446c3b0de2ea"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5e7185d3-2f0f-4ece-b196-95241a57ac68"",
                    ""path"": ""<DualShockGamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e394067a-836b-4780-b42f-aeb26af6978f"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""237e3257-630b-4712-8ba2-51a89552b9a1"",
                    ""path"": ""<DualShockGamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""95470a36-21d0-4b19-82f6-2d63d6b02c70"",
                    ""path"": ""<DualShockGamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""a36e326e-b43a-4f5d-b763-9dacd8d51ae9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""29992bc9-c318-4291-95ac-af37f2e1a5a0"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/hat/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""USBJoystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ab6be6aa-c8df-4f24-9bf3-633f2ae9aa88"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""USBJoystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""34a09506-213a-4357-bc5d-04449b7f8144"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/hat/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""USBJoystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bc78f34e-0299-4b9d-be78-9a6a7d8d10ba"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/hat/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""USBJoystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""f3efed86-d43a-40a9-8830-44cce67faac3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2240995a-70bd-451e-a964-f6f8897f17e8"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""USBJoystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""517752a2-f578-4bac-b5be-74d984170e8a"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""USBJoystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""566042bc-5bc1-4176-8567-36b24801e60d"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""USBJoystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1c923cb3-f114-4439-aae2-d25edc317cf4"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""USBJoystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d3cc8de2-d762-45a8-9502-18d7e618aa81"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c130ffe3-5ecf-4a13-bcd7-0f8f9cb1df94"",
                    ""path"": ""<HID:: USB Gamepad          >/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""132727e3-8c12-4e3e-8b67-7edb8afe2fb9"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64b4ebd4-3f76-43c4-9fa0-642146d4b97a"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""518e609b-7f8d-42af-a682-dd6a33320257"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""USBJoystick"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a27eb19-20fd-4484-845e-24bd344f106c"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e6e8142-5e38-4115-a416-368899353579"",
                    ""path"": ""<HID:: USB Gamepad          >/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abe1e39c-1fe7-4e1b-9376-866c04b66050"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d968b36-65c8-4b51-9e90-c571df303aec"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fba7a74b-844c-4a08-99ec-841b3425c125"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""USBJoystick"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0dc45596-8d7f-4d67-9d4b-6c440523d7b1"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""FightState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec1c8189-9bad-412e-9fa2-e70d40e2950d"",
                    ""path"": ""<HID:: USB Gamepad          >/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""FightState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7589c00d-23e8-4bbf-ab7d-aa2c2b2b945a"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""FightState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45408015-7620-4ba0-8d90-1b81a7331922"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""USBJoystick"",
                    ""action"": ""FightState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c833f085-ec96-48f5-bdb3-0efbdf772c1d"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""FightState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1875bfc9-3c6a-4367-888f-b03738141889"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""StrongAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""380588a8-9794-4a9a-817a-9a642c937e76"",
                    ""path"": ""<HID:: USB Gamepad          >/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""StrongAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa4d513c-e861-4b9b-90ae-879d71854d61"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""StrongAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""705496b0-b4d3-4a99-96c5-241082b77614"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""StrongAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a9e7805-0a86-4dd8-9c7c-556312fffee7"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""USBJoystick"",
                    ""action"": ""StrongAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""815b6d34-b42a-4214-bded-d28a5a824ce4"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""SoftAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fd1358f-9ee4-4b46-8d98-b7fd89b889bc"",
                    ""path"": ""<HID:: USB Gamepad          >/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""SoftAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67122e55-4cc6-4258-aeb4-5e6f6ec21a3f"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""SoftAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16a53c65-5fed-42c7-9ec5-a61828dc2402"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""USBJoystick"",
                    ""action"": ""SoftAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52bbc5d0-f89a-44ec-bd88-4bdae29accf0"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""SoftAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""940c9525-be38-4a44-806c-76b6914edaf7"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Targeter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8328531-fede-4962-ad83-043898d08528"",
                    ""path"": ""<HID:: USB Gamepad          >/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Targeter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""807d9e77-44e8-4056-a2f5-46b8b375fe44"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Gamepad"",
                    ""action"": ""Targeter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1919807-80c9-49c2-a978-b134c0f132ab"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Targeter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<HID:: USB Gamepad          >"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<HID::Microntek              USB Joystick          >"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KeyBoard"",
            ""bindingGroup"": ""KeyBoard"",
            ""devices"": []
        },
        {
            ""name"": ""XboxGamepad"",
            ""bindingGroup"": ""XboxGamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""PS4Gamepad"",
            ""bindingGroup"": ""PS4Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""USBJoystick"",
            ""bindingGroup"": ""USBJoystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<HID::Microntek              USB Joystick          >"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Roll = m_Player.FindAction("Roll", throwIfNotFound: true);
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        m_Player_FightState = m_Player.FindAction("FightState", throwIfNotFound: true);
        m_Player_StrongAttack = m_Player.FindAction("StrongAttack", throwIfNotFound: true);
        m_Player_SoftAttack = m_Player.FindAction("SoftAttack", throwIfNotFound: true);
        m_Player_Targeter = m_Player.FindAction("Targeter", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Roll;
    private readonly InputAction m_Player_Run;
    private readonly InputAction m_Player_FightState;
    private readonly InputAction m_Player_StrongAttack;
    private readonly InputAction m_Player_SoftAttack;
    private readonly InputAction m_Player_Targeter;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Roll => m_Wrapper.m_Player_Roll;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputAction @FightState => m_Wrapper.m_Player_FightState;
        public InputAction @StrongAttack => m_Wrapper.m_Player_StrongAttack;
        public InputAction @SoftAttack => m_Wrapper.m_Player_SoftAttack;
        public InputAction @Targeter => m_Wrapper.m_Player_Targeter;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Roll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @Run.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @FightState.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFightState;
                @FightState.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFightState;
                @FightState.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFightState;
                @StrongAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrongAttack;
                @StrongAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrongAttack;
                @StrongAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrongAttack;
                @SoftAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSoftAttack;
                @SoftAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSoftAttack;
                @SoftAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSoftAttack;
                @Targeter.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargeter;
                @Targeter.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargeter;
                @Targeter.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargeter;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @FightState.started += instance.OnFightState;
                @FightState.performed += instance.OnFightState;
                @FightState.canceled += instance.OnFightState;
                @StrongAttack.started += instance.OnStrongAttack;
                @StrongAttack.performed += instance.OnStrongAttack;
                @StrongAttack.canceled += instance.OnStrongAttack;
                @SoftAttack.started += instance.OnSoftAttack;
                @SoftAttack.performed += instance.OnSoftAttack;
                @SoftAttack.canceled += instance.OnSoftAttack;
                @Targeter.started += instance.OnTargeter;
                @Targeter.performed += instance.OnTargeter;
                @Targeter.canceled += instance.OnTargeter;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    private int m_KeyBoardSchemeIndex = -1;
    public InputControlScheme KeyBoardScheme
    {
        get
        {
            if (m_KeyBoardSchemeIndex == -1) m_KeyBoardSchemeIndex = asset.FindControlSchemeIndex("KeyBoard");
            return asset.controlSchemes[m_KeyBoardSchemeIndex];
        }
    }
    private int m_XboxGamepadSchemeIndex = -1;
    public InputControlScheme XboxGamepadScheme
    {
        get
        {
            if (m_XboxGamepadSchemeIndex == -1) m_XboxGamepadSchemeIndex = asset.FindControlSchemeIndex("XboxGamepad");
            return asset.controlSchemes[m_XboxGamepadSchemeIndex];
        }
    }
    private int m_PS4GamepadSchemeIndex = -1;
    public InputControlScheme PS4GamepadScheme
    {
        get
        {
            if (m_PS4GamepadSchemeIndex == -1) m_PS4GamepadSchemeIndex = asset.FindControlSchemeIndex("PS4Gamepad");
            return asset.controlSchemes[m_PS4GamepadSchemeIndex];
        }
    }
    private int m_USBJoystickSchemeIndex = -1;
    public InputControlScheme USBJoystickScheme
    {
        get
        {
            if (m_USBJoystickSchemeIndex == -1) m_USBJoystickSchemeIndex = asset.FindControlSchemeIndex("USBJoystick");
            return asset.controlSchemes[m_USBJoystickSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnFightState(InputAction.CallbackContext context);
        void OnStrongAttack(InputAction.CallbackContext context);
        void OnSoftAttack(InputAction.CallbackContext context);
        void OnTargeter(InputAction.CallbackContext context);
    }
}
