﻿using Microsoft.AspNetCore.Mvc;
using SmartSchool.Students.Domain.Models;

namespace SmartSchool.Students.Students.Display
{
    public class StudentInfoController : StudentsBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(StudentBasicInfo[]), 200)]
        public async Task<IActionResult> ListStudents([FromQuery] PagingOptions paging, CancellationToken token)
        {
            var result = await Mediator.Send(new ListStudents(paging), token);

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(StudentDetails), 200)]
        public async Task<IActionResult> GetStudentDetails(int id)
        {
            var query = new GetStudentDetails(id);
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}

public record PagingOptions(int PageNumber = 1, int PageSize = 10);

public record StudentDetails(int StudentId, string FirstName, string LastName, string? Email, DateTime DateOfBirth, 
    string? PhoneNumber, AddressDetails? Address, ICollection<StudentRelative> Relatives)
{
    public static StudentDetails FromStudent(Student student)
    {
        return new StudentDetails(student.Id, student.FirstName, student.LastName, 
            student.Email, student.DateOfBirth, student.PhoneNumber, AddressDetails.FromAddress(student.Address),
            student.Relatives.Select(StudentRelative.FromRelative).ToList());
    }
};

public record AddressDetails(string Street, int StreetNumber, string City, string State, string PostalCode, string Country)
{
    public static AddressDetails FromAddress(Address? address)
    {
        if (address is not null)
        {
            return new AddressDetails(address.Street, address.StreetNumber, address.City, address.State, address.PostalCode, address.Country);
        }

        return null!;
    }
};

public record StudentRelative( bool IsGuardian, string FirstName, string LastName, RelativeType RelationToStudent)
{
    public static StudentRelative FromRelative(Relative relative)
    {
        return new StudentRelative(relative.IsGuardian, relative.FirstName, relative.LastName, relative.RelationshipToStudent);
    }
};