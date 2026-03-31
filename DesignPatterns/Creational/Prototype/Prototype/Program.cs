using Prototype;

Report original = new Report("Monthly Report", "Sales data...");

Report copy1 = (Report)original.Clone();
copy1.Title = "Monthly Report - Copy 1";

Report copy2 = (Report)original.Clone();
copy2.Title = "Monthly Report - Copy 2";

original.Show();
copy1.Show();
copy2.Show();