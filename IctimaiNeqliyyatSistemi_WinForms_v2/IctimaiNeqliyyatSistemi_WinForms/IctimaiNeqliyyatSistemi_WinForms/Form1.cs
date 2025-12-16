using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace IctimaiNeqliyyatSistemi_WinForms
{
    public partial class Form1 : Form
    {
        private TransportState _state = new();

        private readonly BindingList<Stop> _stops = new();
        private readonly BindingList<Route> _routes = new();
        private readonly BindingList<TripView> _tripViews = new();
        private readonly BindingList<SaleView> _saleViews = new();

        public Form1()
        {
            InitializeComponent();

            // Grid basic settings (designer ilə də etmək olar, amma burada yalnız xırda UI davranışıdır)
            ConfigureGrid(gridStops);
            ConfigureGrid(gridRoutes);
            ConfigureGrid(gridTrips);
            ConfigureGrid(gridSales);

            // Combo items
            cmbPassengerType.DataSource = Enum.GetValues(typeof(PassengerType));
            cmbPaymentType.DataSource = Enum.GetValues(typeof(PaymentType));

            // Bind grids
            gridStops.DataSource = _stops;
            gridRoutes.DataSource = _routes;
            gridTrips.DataSource = _tripViews;
            gridSales.DataSource = _saleViews;

            // Events (designer-dən də qoşa bilərdin; burada rahatlıq üçün qoşulub)
            gridStops.SelectionChanged += (_, __) => FillStopInputsFromSelection();
            gridRoutes.SelectionChanged += (_, __) => FillRouteInputsFromSelection();
            gridTrips.SelectionChanged += (_, __) => FillTripInputsFromSelection();

            LoadAll();
        }

        private void ConfigureGrid(DataGridView g)
        {
            g.AutoGenerateColumns = true;
            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.RowHeadersVisible = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadAll()
        {
            _state = DataStore.Load();

            EnsureDemoDataIfEmpty();

            _stops.Clear();
            foreach (var s in _state.Stops.OrderBy(x => x.Name))
                _stops.Add(s);

            _routes.Clear();
            foreach (var r in _state.Routes.OrderBy(x => x.Code))
                _routes.Add(r);

            RefreshStopsChecklist();
            RefreshTripViews();
            RefreshTripCombo();
            RefreshSalesViews();
            RefreshReport();
        }

        private void SaveAll()
        {
            DataStore.Save(_state);
        }

private void EnsureDemoDataIfEmpty()
{
    // İlk dəfə açanda ComboBox-lar boş qalmasın deyə demo məlumatlar yaradırıq.
    // Müəllimə izah: bu "seed" real sistem deyil, sadəcə test üçün nümunədir.
    if (_state.Stops.Count == 0 && _state.Routes.Count == 0 && _state.Trips.Count == 0 && _state.Sales.Count == 0)
    {
        var s1 = new Stop { Name = "28 May", District = "Nəsimi" };
        var s2 = new Stop { Name = "Gənclik", District = "Nəsimi" };
        var s3 = new Stop { Name = "Koroğlu", District = "Nərimanov" };
        _state.Stops.AddRange(new[] { s1, s2, s3 });

        var r1 = new Route { Code = "1", Name = "28 May → Koroğlu", StopIds = new List<Guid> { s1.Id, s2.Id, s3.Id } };
        _state.Routes.Add(r1);

        var t1 = new Trip { RouteId = r1.Id, Departure = DateTime.Now.AddMinutes(30), BusNo = "12" };
        _state.Trips.Add(t1);

        DataStore.Save(_state);
    }
}


        // -------------------- Stops --------------------
        private void btnStopAdd_Click(object sender, EventArgs e)
        {
            var name = txtStopName.Text.Trim();
            var district = txtStopDistrict.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Dayanacaq adı boş ola bilməz.");
                return;
            }

            var stop = new Stop { Name = name, District = district };
            _state.Stops.Add(stop);
            _stops.Add(stop);

            SaveAll();
            RefreshStopsChecklist();

            txtStopName.Clear();
            txtStopDistrict.Clear();
        }

        private void btnStopUpdate_Click(object sender, EventArgs e)
        {
            var selected = SelectedStop();
            if (selected == null)
            {
                MessageBox.Show("Yeniləmək üçün dayanacaq seçin.");
                return;
            }

            var name = txtStopName.Text.Trim();
            var district = txtStopDistrict.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Dayanacaq adı boş ola bilməz.");
                return;
            }

            selected.Name = name;
            selected.District = district;

            // refresh grid
            gridStops.Refresh();

            SaveAll();
            RefreshStopsChecklist();
            RefreshTripViews();
            RefreshTripCombo();
        }

        private void btnStopDelete_Click(object sender, EventArgs e)
        {
            var selected = SelectedStop();
            if (selected == null)
            {
                MessageBox.Show("Silmək üçün dayanacaq seçin.");
                return;
            }

            // If stop is used in any route, prevent delete to keep consistency
            var used = _state.Routes.Any(r => r.StopIds.Contains(selected.Id));
            if (used)
            {
                MessageBox.Show("Bu dayanacaq marşrutlarda istifadə olunur. Əvvəl marşrutdan çıxarın.");
                return;
            }

            _state.Stops.RemoveAll(s => s.Id == selected.Id);
            _stops.Remove(selected);

            SaveAll();
            RefreshStopsChecklist();
            RefreshTripViews();
            RefreshTripCombo();

            txtStopName.Clear();
            txtStopDistrict.Clear();
        }

        private Stop? SelectedStop()
        {
            if (gridStops.CurrentRow?.DataBoundItem is Stop s)
                return s;
            return null;
        }

        private void FillStopInputsFromSelection()
        {
            var s = SelectedStop();
            if (s == null) return;
            txtStopName.Text = s.Name;
            txtStopDistrict.Text = s.District;
        }

        private void RefreshStopsChecklist()
        {
            clbRouteStops.Items.Clear();
            foreach (var s in _state.Stops.OrderBy(x => x.Name))
            {
                clbRouteStops.Items.Add(s, false);
            }
        }

        // -------------------- Routes --------------------
        private void btnRouteAdd_Click(object sender, EventArgs e)
        {
            var code = txtRouteCode.Text.Trim();
            var name = txtRouteName.Text.Trim();

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Marşrut kodu və adı boş ola bilməz.");
                return;
            }

            if (_state.Routes.Any(r => r.Code.Equals(code, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Bu kodla marşrut artıq var.");
                return;
            }

            var selectedStops = GetCheckedStops();
            if (selectedStops.Count < 2)
            {
                MessageBox.Show("Marşrut üçün ən az 2 dayanacaq seçin.");
                return;
            }

            var route = new Route
            {
                Code = code,
                Name = name,
                StopIds = selectedStops.Select(s => s.Id).ToList()
            };

            _state.Routes.Add(route);
            _routes.Add(route);

            SaveAll();
            RefreshTripViews();
            RefreshTripCombo();
            RefreshReport();

            txtRouteCode.Clear();
            txtRouteName.Clear();
            ClearRouteStopChecks();
        }

        private void btnRouteUpdate_Click(object sender, EventArgs e)
        {
            var selected = SelectedRoute();
            if (selected == null)
            {
                MessageBox.Show("Yeniləmək üçün marşrut seçin.");
                return;
            }

            var code = txtRouteCode.Text.Trim();
            var name = txtRouteName.Text.Trim();

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Marşrut kodu və adı boş ola bilməz.");
                return;
            }

            // if code changed, ensure unique
            if (!selected.Code.Equals(code, StringComparison.OrdinalIgnoreCase) &&
                _state.Routes.Any(r => r.Code.Equals(code, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Bu kodla başqa marşrut artıq var.");
                return;
            }

            var stops = GetCheckedStops();
            if (stops.Count < 2)
            {
                MessageBox.Show("Marşrut üçün ən az 2 dayanacaq seçin.");
                return;
            }

            selected.Code = code;
            selected.Name = name;
            selected.StopIds = stops.Select(s => s.Id).ToList();

            gridRoutes.Refresh();

            SaveAll();
            RefreshTripViews();
            RefreshTripCombo();
            RefreshReport();
        }

        private void btnRouteDelete_Click(object sender, EventArgs e)
        {
            var selected = SelectedRoute();
            if (selected == null)
            {
                MessageBox.Show("Silmək üçün marşrut seçin.");
                return;
            }

            var usedByTrips = _state.Trips.Any(t => t.RouteId == selected.Id);
            if (usedByTrips)
            {
                MessageBox.Show("Bu marşrut reyslərdə istifadə olunur. Əvvəl reysləri silin.");
                return;
            }

            _state.Routes.RemoveAll(r => r.Id == selected.Id);
            _routes.Remove(selected);

            SaveAll();
            RefreshTripViews();
            RefreshTripCombo();
            RefreshReport();

            txtRouteCode.Clear();
            txtRouteName.Clear();
            ClearRouteStopChecks();
        }

        private Route? SelectedRoute()
        {
            if (gridRoutes.CurrentRow?.DataBoundItem is Route r)
                return r;
            return null;
        }

        private List<Stop> GetCheckedStops()
        {
            return clbRouteStops.CheckedItems
                .OfType<Stop>()
                .ToList();
        }

        private void ClearRouteStopChecks()
        {
            for (int i = 0; i < clbRouteStops.Items.Count; i++)
                clbRouteStops.SetItemChecked(i, false);
        }

        private void FillRouteInputsFromSelection()
        {
            var r = SelectedRoute();
            if (r == null) return;

            txtRouteCode.Text = r.Code;
            txtRouteName.Text = r.Name;

            // check stops
            for (int i = 0; i < clbRouteStops.Items.Count; i++)
            {
                if (clbRouteStops.Items[i] is Stop s)
                    clbRouteStops.SetItemChecked(i, r.StopIds.Contains(s.Id));
            }
        }

        // -------------------- Trips --------------------
        private void btnTripAdd_Click(object sender, EventArgs e)
        {
            if (_state.Routes.Count == 0)
            {
                MessageBox.Show("Heç bir marşrut yoxdur. Əvvəl Marşrutlar bölməsində marşrut əlavə edin.");
                return;
            }

            if (cmbTripRoute.SelectedItem is not Route route)
            {
                MessageBox.Show("Marşrut seçin.");
                return;
            }

            var busNo = txtTripBusNo.Text.Trim();
            if (string.IsNullOrWhiteSpace(busNo))
            {
                MessageBox.Show("Avtobus nömrəsi boş ola bilməz.");
                return;
            }

            var trip = new Trip
            {
                RouteId = route.Id,
                Departure = dtTripDeparture.Value,
                BusNo = busNo
            };

            _state.Trips.Add(trip);

            SaveAll();
            RefreshTripViews();
            RefreshTripCombo();

            txtTripBusNo.Clear();
        }

        private void btnTripUpdate_Click(object sender, EventArgs e)
        {
            var selected = SelectedTrip();
            if (selected == null)
            {
                MessageBox.Show("Yeniləmək üçün reys seçin.");
                return;
            }

            if (_state.Routes.Count == 0)
            {
                MessageBox.Show("Heç bir marşrut yoxdur. Əvvəl Marşrutlar bölməsində marşrut əlavə edin.");
                return;
            }

            if (cmbTripRoute.SelectedItem is not Route route)
            {
                MessageBox.Show("Marşrut seçin.");
                return;
            }

            var busNo = txtTripBusNo.Text.Trim();
            if (string.IsNullOrWhiteSpace(busNo))
            {
                MessageBox.Show("Avtobus nömrəsi boş ola bilməz.");
                return;
            }

            selected.RouteId = route.Id;
            selected.Departure = dtTripDeparture.Value;
            selected.BusNo = busNo;

            SaveAll();
            RefreshTripViews();
            RefreshTripCombo();
            RefreshSalesViews();
            RefreshReport();
        }

        private void btnTripDelete_Click(object sender, EventArgs e)
        {
            var selected = SelectedTrip();
            if (selected == null)
            {
                MessageBox.Show("Silmək üçün reys seçin.");
                return;
            }

            var hasSales = _state.Sales.Any(s => s.TripId == selected.Id);
            if (hasSales)
            {
                MessageBox.Show("Bu reys üçün bilet satılıb. Əvvəl satışları silmək lazım olardı (bu demo-da bloklanır).");
                return;
            }

            _state.Trips.RemoveAll(t => t.Id == selected.Id);

            SaveAll();
            RefreshTripViews();
            RefreshTripCombo();
            RefreshReport();

            txtTripBusNo.Clear();
        }

        private Trip? SelectedTrip()
        {
            // Grid trips is bound to view; map back
            if (gridTrips.CurrentRow?.DataBoundItem is TripView v)
                return _state.Trips.FirstOrDefault(t => t.Id == v.Id);
            return null;
        }

        private void FillTripInputsFromSelection()
        {
            var t = SelectedTrip();
            if (t == null) return;

            var route = _state.Routes.FirstOrDefault(r => r.Id == t.RouteId);
            if (route != null)
                cmbTripRoute.SelectedItem = route;

            dtTripDeparture.Value = t.Departure;
            txtTripBusNo.Text = t.BusNo;
        }

        private void RefreshTripViews()
        {
            _tripViews.Clear();

            foreach (var t in _state.Trips.OrderBy(x => x.Departure))
            {
                var r = _state.Routes.FirstOrDefault(rr => rr.Id == t.RouteId);
                var routeText = r == null ? "—" : r.ToString();
                _tripViews.Add(new TripView
                {
                    Id = t.Id,
                    Route = routeText,
                    Departure = t.Departure,
                    BusNo = t.BusNo
                });
            }

            // Route dropdown for trip creation/edit
            cmbTripRoute.DataSource = null;
            cmbTripRoute.DataSource = _state.Routes.OrderBy(x => x.Code).ToList();
        }

        private void RefreshTripCombo()
        {
            cmbSaleTrip.DataSource = null;

            var items = _state.Trips
                .OrderByDescending(t => t.Departure)
                .Select(t =>
                {
                    var r = _state.Routes.FirstOrDefault(rr => rr.Id == t.RouteId);
                    var routeText = r == null ? "—" : r.ToString();
                    return new TripComboItem(t.Id, $"{routeText} | {t.Departure:dd.MM.yyyy HH:mm} | Bus: {t.BusNo}");
                })
                .ToList();

            cmbSaleTrip.DataSource = items;
            cmbSaleTrip.DisplayMember = nameof(TripComboItem.Text);
        }

        // -------------------- Sales --------------------
        private void btnSellTicket_Click(object sender, EventArgs e)
        {
            if (cmbSaleTrip.SelectedItem is not TripComboItem tripItem)
            {
                MessageBox.Show("Reys seçin.");
                return;
            }

            if (cmbPassengerType.SelectedItem is not PassengerType passenger)
            {
                MessageBox.Show("Sərnişin tipi seçin.");
                return;
            }

            if (cmbPaymentType.SelectedItem is not PaymentType payment)
            {
                MessageBox.Show("Ödəniş tipi seçin.");
                return;
            }

            var price = numPrice.Value;
            if (price <= 0)
            {
                MessageBox.Show("Qiymət 0-dan böyük olmalıdır.");
                return;
            }

            var sale = new TicketSale
            {
                TripId = tripItem.TripId,
                PassengerType = passenger,
                PaymentType = payment,
                Price = price,
                SoldAt = DateTime.Now
            };

            _state.Sales.Add(sale);
            SaveAll();

            RefreshSalesViews();
            RefreshReport();

            MessageBox.Show("Bilet satıldı ✅");
        }

        private void RefreshSalesViews()
        {
            _saleViews.Clear();

            foreach (var s in _state.Sales.OrderByDescending(x => x.SoldAt))
            {
                var t = _state.Trips.FirstOrDefault(tt => tt.Id == s.TripId);
                string tripText = "—";
                if (t != null)
                {
                    var r = _state.Routes.FirstOrDefault(rr => rr.Id == t.RouteId);
                    var routeText = r == null ? "—" : r.ToString();
                    tripText = $"{routeText} | {t.Departure:dd.MM.yyyy HH:mm} | Bus: {t.BusNo}";
                }

                _saleViews.Add(new SaleView
                {
                    Id = s.Id,
                    Trip = tripText,
                    SoldAt = s.SoldAt,
                    PassengerType = s.PassengerType.ToString(),
                    PaymentType = s.PaymentType.ToString(),
                    Price = s.Price
                });
            }
        }

        // -------------------- Report --------------------
        private void btnRefreshReport_Click(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void RefreshReport()
        {
            var today = DateTime.Today;
            var todaySales = _state.Sales.Where(s => s.SoldAt.Date == today).ToList();

            lblTodayCount.Text = $"Bugün satılan bilet: {todaySales.Count}";
            lblTodayRevenue.Text = $"Bugün gəlir: {todaySales.Sum(s => s.Price):0.00} AZN";
        }

        // -------------------- Small helper view models --------------------
        private sealed class TripView
        {
            public Guid Id { get; set; }
            public string Route { get; set; } = "";
            public DateTime Departure { get; set; }
            public string BusNo { get; set; } = "";
        }

        private sealed class SaleView
        {
            public Guid Id { get; set; }
            public string Trip { get; set; } = "";
            public DateTime SoldAt { get; set; }
            public string PassengerType { get; set; } = "";
            public string PaymentType { get; set; } = "";
            public decimal Price { get; set; }
        }

        private sealed record TripComboItem(Guid TripId, string Text);
    }
}
