using System;
using System.Collections;
using System.Collections.Generic;
using Factories;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Factories")] // Grouping related variables for clarity in the Unity Inspector
    public AirFactory airFactory;
    public CarFactory carFactory;
    public TankFactory tankFactory;

    private Vector3 _deliveryPosition = new Vector3(-27, 0, -122); // Default delivery position
    public TextMeshProUGUI textVehicle;

    // Enum for different types of vehicles that can be produced
    enum VehicleToProduce
    {
        Car1,
        Car2,
        Car3,
        Helicopter,
        Aeroplane,
        Tank
    }

    VehicleToProduce Vehicle = VehicleToProduce.Car1; // Default vehicle to produce

    // Method to set which vehicle to produce based on input from UI
    public void WhatToProduce(int vehicleId)
    {
        switch (vehicleId)
        {
            case 0:
                Vehicle = VehicleToProduce.Car1;
                textVehicle.text = "Car 1";
                break;
            case 1:
                Vehicle = VehicleToProduce.Car2;
                textVehicle.text = "Car 2";
                break;
            case 2:
                Vehicle = VehicleToProduce.Car3;
                textVehicle.text = "Car 3";
                break;
            case 3:
                Vehicle = VehicleToProduce.Helicopter;
                textVehicle.text = "Helicopter";
                break;
            case 4:
                Vehicle = VehicleToProduce.Aeroplane;
                textVehicle.text = "Aeroplane";
                break;
            case 5:
                Vehicle = VehicleToProduce.Tank;
                textVehicle.text = "Tank"; 
                break;
        }
    }

    // Method to handle user input for producing vehicles
    private void Update()
    {
        // Check for key presses corresponding to vehicle selection
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            SetDeliverySlot(0); 
            ProduceVehicle(); 
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetDeliverySlot(1);
            ProduceVehicle();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetDeliverySlot(2);
            ProduceVehicle();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetDeliverySlot(3);
            ProduceVehicle();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetDeliverySlot(4);
            ProduceVehicle();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SetDeliverySlot(5);
            ProduceVehicle();
        }
    }

    // Method to produce the selected vehicle based on the current Vehicle enum value
    public void ProduceVehicle()
    {
        switch (Vehicle)
        {
            case VehicleToProduce.Car1:
                carFactory.GetProduct(CarFactory.CAR_TYPE_1, _deliveryPosition);
                break;
            case VehicleToProduce.Car2:
                carFactory.GetProduct(CarFactory.CAR_TYPE_2, _deliveryPosition);
                break;
            case VehicleToProduce.Car3:
                carFactory.GetProduct(CarFactory.CAR_TYPE_3, _deliveryPosition);
                break;
            case VehicleToProduce.Helicopter:
                airFactory.GetProduct(AirFactory.HELICOPTER, _deliveryPosition);
                break;
            case VehicleToProduce.Aeroplane:
                airFactory.GetProduct(AirFactory.AEROPLANE, _deliveryPosition);
                break;
            case VehicleToProduce.Tank:
                tankFactory.GetProduct(TankFactory.TANK_TYPE_1, _deliveryPosition);
                break;
        }
    }

    // Method to set the delivery position based on the delivery slot
    public void SetDeliverySlot(int slot)
    {
        switch (slot)
        {
            case 1:
                _deliveryPosition = new Vector3(-32, 0, -122);
                break;
            case 2:
                _deliveryPosition = new Vector3(-37, 0, -122);
                break;
            case 3:
                _deliveryPosition = new Vector3(-27, 0, -115);
                break;
            case 4:
                _deliveryPosition = new Vector3(-32, 0, -115);
                break;
            case 5:
                _deliveryPosition = new Vector3(-37, 0, -115);
                break;
            default: 
                _deliveryPosition = new Vector3(-27, 0, -122); 
                break;
        }
    }
}
