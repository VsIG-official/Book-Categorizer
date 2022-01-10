# Book Categorizer

<p align="center">
  <img src="docs\ASP.NET.png" data-canonical-src="docs\ASP.NET.png" width="200" height="200" />
</p>

## Table of Contents

- [Description](#description)
- [Badges](#badges)
- [Contributing](#contributing)
- [License](#license)

### Description

Just a small project on ASP.NET using this [tutorial](https://www.youtube.com/watch?v=hZ1DASYd9rk&ab_channel=freeCodeCamp.org)

## Badges

[![Theme](https://img.shields.io/badge/Theme-WEB-blueviolet)](https://img.shields.io/badge/Theme-WEB-blueviolet)
[![Tool](https://img.shields.io/badge/Tool-ASP.NET-blueviolet)](https://img.shields.io/badge/Tool-ASP.NET-blueviolet)

---

## Example

```csharp
 // POST
[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Create(Categorycategory)
{
    if (category.Name == category.DisplayOrder.ToString())
    {
        ModelState.AddModelError("CustomError","The DisplayOrder cannot exactly match the Name");
    }
    if (ModelState.IsValid)
    {
        _db.Categories.Add(category);
        _db.SaveChanges();
        TempData["success"] = "Category created successfully";
        return RedirectToAction("Index");
    }
    return View(category);
}
// GET
public IActionResult Edit(int id)
{
    if (id == 0)
    {
        return NotFound();
    }
    var category = _db.Categories.Find(id);
    if (category == null)
    {
        return NotFound();
    }
    return View(category);
}
```

---

## Contributing

> To get started...

### Step 1

- 🍴 Fork this repo!

### Step 2

- **HACK AWAY!** 🔨🔨🔨

---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright 2021 © <a href="https://github.com/VsIG-official" target="_blank">VsIG</a>.
