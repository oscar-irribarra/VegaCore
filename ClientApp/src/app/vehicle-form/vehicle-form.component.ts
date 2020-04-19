import { MakeService } from "./../services/make.service";
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

  constructor(private makesService: MakeService) {}

  ngOnInit() {
    console.log("Entro");
    this.makesService.getMakes().subscribe((resp) => {
      this.makesList = resp;
    });
  }

  onMakeChange() {
    let selectedMake = this.makesList.find((x) => x.id == this.vehicle.make).models;
    this.modelsList = selectedMake ? selectedMake : [];
  }
}
