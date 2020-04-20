import { VehicleService } from "../services/vehicle.service";
import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-vehicle-form",
  templateUrl: "./vehicle-form.component.html",
  styleUrls: ["./vehicle-form.component.css"],
})
export class VehicleFormComponent implements OnInit {
  public makesList: any[];
  public modelsList: any[];
  public vehicle: any = {};
  public features: any[];

  constructor(private vehicleService: VehicleService) {}

  ngOnInit() {
    this.vehicleService.getMakes().subscribe((resp) => {
      this.makesList = resp;
    });

    this.vehicleService.getFeatures().subscribe(resp => {
      this.features = resp;
    });
  }

  onMakeChange() {
    let selectedMake = this.makesList.find((x) => x.id == this.vehicle.make).models;
    this.modelsList = selectedMake ? selectedMake : [];
  }
}
