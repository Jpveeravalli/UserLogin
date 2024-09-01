using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class User
{
    public byte Id { get; set; }

    public string? Name { get; set; }

    public string UserName { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public byte[] Password { get; set; } = null!;
}
