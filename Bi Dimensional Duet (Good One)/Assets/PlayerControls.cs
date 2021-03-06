// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""3a303b2c-740f-4220-973f-25c272d97146"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""312187f6-ad51-4ab7-8b77-36d51db513e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""bd08ba2d-17e4-4b56-807c-de6a7cdcee3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap(tapCount=1)""
                },
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""d708feb1-6f18-44df-91f9-0bf335ff4028"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Change"",
                    ""type"": ""Button"",
                    ""id"": ""5daa4586-422c-4835-8589-83d1d4fd204e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accept"",
                    ""type"": ""Button"",
                    ""id"": ""bbc8e5bc-5df6-49fa-879c-f81c76ec4b45"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap(tapCount=1)""
                },
                {
                    ""name"": ""Analize"",
                    ""type"": ""Button"",
                    ""id"": ""856039f1-451a-4a00-b615-049f02d6f8e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""a6c80811-9b10-4750-967f-9f9c48d2a863"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Win"",
                    ""type"": ""Button"",
                    ""id"": ""dd144fc7-26b6-4ea5-ad99-511c64edb4c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EnterCaba??a"",
                    ""type"": ""Button"",
                    ""id"": ""b04387d9-24e0-4140-b925-b8ab79db8b61"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Talk"",
                    ""type"": ""Button"",
                    ""id"": ""ef123d97-9606-4d63-9617-68c9d081ce03"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""GamePad"",
                    ""id"": ""1e94f0f2-3c82-4e6e-8971-1febced9403e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b5eeee6a-f629-4f40-adb3-c8d983de66c7"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""836a771f-a31b-4a52-a008-1be861b0a5fa"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""971940d7-694d-442c-b00c-522a39da748b"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7312246f-a73d-4673-8fa3-e3a244330110"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""312d4225-4bc3-4d1d-b280-c2da87449781"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""58c0f7f5-90a7-44db-85fe-dd557e3a8a24"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d53dc2e9-5368-4aa8-a257-94affec894fb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""45655253-6a51-4ae4-a4d2-f4bd1cfc43d1"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8960ba45-d93c-4100-8e69-ece68ef8c2a4"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ASWD"",
                    ""id"": ""7d64385c-f467-4a21-9a99-2be5497bbfeb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9815909f-62d0-4e4b-ba8c-ed9644db6e36"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ee684639-ca82-4bc3-adab-ffadb9c8a261"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""701c4971-e25e-4784-a09d-b8c401289e36"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e2e82c94-74fd-41b4-9c17-1b973c6b551d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9b4112f2-4de3-4ff0-98e0-1de34d4a8558"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f7e68040-f9c9-445b-8aba-38da2aab0242"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""36f350d2-dca8-4da4-98e9-d4e08703963c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9f059626-21ec-4421-83ea-98dda0b28747"",
                    ""path"": ""<HID::Unknown Joy-Con (R)>/hat/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""30a79048-909a-4053-b6a0-f8134b81aa48"",
                    ""path"": ""<HID::Unknown Joy-Con (R)>/hat/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f79ee4c3-b781-4717-b01a-6a13986942b7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e35baa00-d578-4bf2-869e-e138d17f4ef7"",
                    ""path"": ""<HID::Unknown DUALSHOCK 4 Wireless Controller>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27a48461-032f-4706-b4a5-0b61e57b97cb"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd97c322-a5a6-4c29-a15a-c608d7db3cbb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70609f00-c84b-44e2-8c4b-361c4f70932e"",
                    ""path"": ""<HID::Unknown Joy-Con (R)>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7263e23c-d4a5-4074-b2cb-3331a84e0ca2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1a9dbb7c-343b-4d05-8a53-aa004ab30dc2"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7f0505a9-917a-438b-b1b7-c2e588df79e1"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6233d3c9-4911-4ae9-a8f7-d98e03a166f6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c7faaa3a-ccb4-4339-88be-c160b2c5af94"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""543ace29-7a40-4b81-82f9-2da1bb5d43fa"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b0037f45-feed-49f4-954f-a83378c15935"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""194bc77a-812d-490c-a6ca-ff4d73f179bf"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0b751662-928d-4590-bccf-c0129e017e40"",
                    ""path"": ""<HID::Unknown Joy-Con (R)>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c95cc274-d93a-4bbc-8854-a23b1dd2b9dc"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4117df37-ca92-47b3-9316-edab78994519"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ed4702a3-6bcb-418f-b3a1-722d87e65982"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""61a3bb83-d460-4499-bd68-eafe83360b78"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d0244b91-a63c-49ec-aafe-581db9104514"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ba52ac05-e395-4fdb-91d5-0463dad3e463"",
                    ""path"": ""<HID::Unknown DUALSHOCK 4 Wireless Controller>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0ff8e881-b644-4a8b-b0b6-4637f4ff0956"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0b89f859-8e0f-4720-b0c8-5cdda616e6c1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b4cf810d-10cb-430f-960d-db8646704137"",
                    ""path"": ""<HID::Unknown Joy-Con (R)>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f261e021-786b-445a-b3e9-2c9f9867d923"",
                    ""path"": ""<HID::Unknown DUALSHOCK 4 Wireless Controller>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c96a29d2-6f56-4676-84ee-6b149bc58346"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d128f2ad-6b2c-4eaf-b859-796c8cc416ef"",
                    ""path"": ""<HID::Unknown Joy-Con (R)>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9bf365f-e727-4757-993d-f744a9579117"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analize"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58703c46-af50-4d62-9b80-a9842626e598"",
                    ""path"": ""<HID::Unknown DUALSHOCK 4 Wireless Controller>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analize"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc438426-f292-48fd-8cc2-d781990deed1"",
                    ""path"": ""<HID::Unknown DUALSHOCK 4 Wireless Controller>/button10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5884e023-b678-4b44-8982-2df67cc16e64"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""225de35e-da1d-4efa-bff8-b7b6e626cd5d"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Win"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b575a2f-973f-421f-b478-9bb9d247ab7b"",
                    ""path"": ""<HID::Unknown DUALSHOCK 4 Wireless Controller>/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Win"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5e7b362-232f-406d-9f06-e211995fd427"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterCaba??a"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27b7eefe-e107-4ccf-9fdf-7727524933fc"",
                    ""path"": ""<HID::Unknown Joy-Con (R)>/button3"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterCaba??a"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8d9ac6a-e0da-4c26-ac0c-f93fc0381ad1"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c34d691f-fd74-45f4-9dad-34d002e29b2d"",
                    ""path"": ""<HID::Unknown Joy-Con (R)>/button3"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Grab = m_Player.FindAction("Grab", throwIfNotFound: true);
        m_Player_Change = m_Player.FindAction("Change", throwIfNotFound: true);
        m_Player_Accept = m_Player.FindAction("Accept", throwIfNotFound: true);
        m_Player_Analize = m_Player.FindAction("Analize", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
        m_Player_Win = m_Player.FindAction("Win", throwIfNotFound: true);
        m_Player_EnterCaba??a = m_Player.FindAction("EnterCaba??a", throwIfNotFound: true);
        m_Player_Talk = m_Player.FindAction("Talk", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Grab;
    private readonly InputAction m_Player_Change;
    private readonly InputAction m_Player_Accept;
    private readonly InputAction m_Player_Analize;
    private readonly InputAction m_Player_Pause;
    private readonly InputAction m_Player_Win;
    private readonly InputAction m_Player_EnterCaba??a;
    private readonly InputAction m_Player_Talk;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Grab => m_Wrapper.m_Player_Grab;
        public InputAction @Change => m_Wrapper.m_Player_Change;
        public InputAction @Accept => m_Wrapper.m_Player_Accept;
        public InputAction @Analize => m_Wrapper.m_Player_Analize;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputAction @Win => m_Wrapper.m_Player_Win;
        public InputAction @EnterCaba??a => m_Wrapper.m_Player_EnterCaba??a;
        public InputAction @Talk => m_Wrapper.m_Player_Talk;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Grab.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGrab;
                @Change.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChange;
                @Change.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChange;
                @Change.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChange;
                @Accept.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAccept;
                @Accept.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAccept;
                @Accept.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAccept;
                @Analize.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAnalize;
                @Analize.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAnalize;
                @Analize.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAnalize;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Win.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWin;
                @Win.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWin;
                @Win.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWin;
                @EnterCaba??a.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnterCaba??a;
                @EnterCaba??a.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnterCaba??a;
                @EnterCaba??a.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnterCaba??a;
                @Talk.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTalk;
                @Talk.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTalk;
                @Talk.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTalk;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
                @Change.started += instance.OnChange;
                @Change.performed += instance.OnChange;
                @Change.canceled += instance.OnChange;
                @Accept.started += instance.OnAccept;
                @Accept.performed += instance.OnAccept;
                @Accept.canceled += instance.OnAccept;
                @Analize.started += instance.OnAnalize;
                @Analize.performed += instance.OnAnalize;
                @Analize.canceled += instance.OnAnalize;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Win.started += instance.OnWin;
                @Win.performed += instance.OnWin;
                @Win.canceled += instance.OnWin;
                @EnterCaba??a.started += instance.OnEnterCaba??a;
                @EnterCaba??a.performed += instance.OnEnterCaba??a;
                @EnterCaba??a.canceled += instance.OnEnterCaba??a;
                @Talk.started += instance.OnTalk;
                @Talk.performed += instance.OnTalk;
                @Talk.canceled += instance.OnTalk;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnGrab(InputAction.CallbackContext context);
        void OnChange(InputAction.CallbackContext context);
        void OnAccept(InputAction.CallbackContext context);
        void OnAnalize(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnWin(InputAction.CallbackContext context);
        void OnEnterCaba??a(InputAction.CallbackContext context);
        void OnTalk(InputAction.CallbackContext context);
    }
}
