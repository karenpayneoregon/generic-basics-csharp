#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BindingListJsonSample.Models;

public class Customer : INotifyPropertyChanged
{
    private int _id;
    private string _firstName;
    private string _lastName;
    private DateOnly _birthDay;
    private string _email;
    private Gender? _gender;

    public int Id
    {
        get => _id;
        set
        {
            if (value == _id) return;
            _id = value;
            OnPropertyChanged();
        }
    }

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (value == _firstName) return;
            _firstName = value;
            OnPropertyChanged();
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            if (value == _lastName) return;
            _lastName = value;
            OnPropertyChanged();
        }
    }

    public DateOnly BirthDay
    {
        get => _birthDay;
        set
        {
            if (value.Equals(_birthDay)) return;
            _birthDay = value;
            OnPropertyChanged();
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            if (value == _email) return;
            _email = value;
            OnPropertyChanged();
        }
    }

    public Gender? Gender
    {
        get => _gender;
        set
        {
            if (value == _gender) return;
            _gender = value;
            OnPropertyChanged();
        }
    }

    public Customer()
    {
        
    }

    public Customer(int id)
    {
        Id = id;
    }
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}