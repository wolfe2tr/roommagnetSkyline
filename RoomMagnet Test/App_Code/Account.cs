﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Account
/// </summary>
public class Account
{
    private string Password;
    private string FirstName;
    private string MiddleName;
    private string LastName;
    private string PhoneNumber;
    private DateTime BirthDate;
    private string Email;
    private string HouseNumber;
    private string Street;
    private string City;
    private string State;
    private string Zip;
    private string Country;
    private string AccountType;
    private DateTime ModifiedDate;
    private int PermissionID;
    public Account(string Password, string FirstName, string MiddleName, string LastName, string PhoneNumber, DateTime BirthDate, string Email, string HouseNumber, string Street, string City, string State, string Zip, string Country, string AccountType, DateTime ModifiedDate, int PermissionID)
    {
        setPassword(Password);
        setFirstName(FirstName);
        setMiddleName(MiddleName);
        setLastName(LastName);
        setEmail(Email);
        setHouseNum(HouseNumber);
        setStreet(Street);
        setCity(City);
        setState(State);
        setZip(Zip);
        setCountry(Country);
        setAccType(AccountType);
        setModDate(ModifiedDate);
        setPID(PermissionID);
}
    public void setPassword(string password)
    {
        this.Password = password;
    }
    public void setFirstName(string FirstName)
    {
        this.FirstName = FirstName;
    }
    public void setMiddleName(string MiddleName)
    {
        this.MiddleName = MiddleName;
    }
    public void setLastName(string LastName)
    {
        this.LastName = LastName;
    }
    public void setEmail(string Email)
    {
        this.Email = Email;
    }
    public void setHouseNum(string HouseNumber)
    {
        this.HouseNumber = HouseNumber;
    }
    public void setStreet(String Street)
    {
        this.Street = Street;
    }
    public void setCity(string City)
    {
        this.City = City;
    }
    public void setState(string State)
    {
        this.State = State;
    }
    public void setZip(string Zip)
    {
        this.Zip = Zip;
    }
    public void setCountry(string Country)
    {
        this.Country = Country;
    }
    public void setAccType(string AccountType)
    {
        this.AccountType = AccountType;
    }
    public void setModDate(DateTime ModifiedDate)
    {
        this.ModifiedDate = ModifiedDate;
    }
    public void setPID(int PermissionID)
    {
        this.PermissionID = PermissionID;
    }



    //getter
    public string getPassword()
    {
        return this.Password;
    }
    public string getFirstName()
    {
        return this.FirstName;
    }
    public string getLastName()
    {
        return this.LastName;
    }
    public string getEmail()
    {
        return this.Email;
    }
    public string getHouseNumber()
    {
        return this.HouseNumber;
    }
    public string getStreet()
    {
        return this.Street;
    }
    public string getCity()
    {
        return this.City;
    }
    public string getState()
    {
        return this.State;
    }
    public string getZip()
    {
        return this.Zip;
    }
    public string getCountry()
    {
        return this.Country;
    }
    public string getAccType()
    {
        return this.AccountType
    }
    public DateTime getModDate()
    {
        return this.ModifiedDate;
    }
    public int getPID()
    {
        return this.PermissionID;
    }
}