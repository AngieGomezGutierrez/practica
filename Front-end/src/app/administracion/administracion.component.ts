import { Component, Inject, OnInit } from '@angular/core';
import { Usuario } from '../model/dataUsers';
import { MAT_DIALOG_DATA, MatDialog, MatDialogModule } from '@angular/material/dialog';
import { NgIf } from '@angular/common';
import { ApiService } from '../service/api.service';
import { log } from 'console';

@Component({
  templateUrl: './administracion.component.html',
  styleUrls: ['./administracion.component.scss']
})
export class AdministracionComponent implements OnInit {

  selectedDepartamento = "";
  selectedCargo = "";

  departamentos = [];
  cargos = [];

  displayedColumns: string[] = ['usuario', 'nombres', 'apellidos', 'departamento', 'cargo', 'email', 'opciones'];

  datosUsuarios: Usuario[] = [
    {
      usuario: "Juan45",
      nombres: "Juan",
      apellidos: "Lopez",
      cargo: "Administrador",
      departamento: "Tecnologia",
      email: "prueba@prueba.com",
    },
    {
      usuario: "Juan45",
      nombres: "Juan",
      apellidos: "Lopez",
      cargo: "Administrador",
      departamento: "Tecnologia",
      email: "prueba@prueba.com",
    },
  ];

  constructor(
    public dialog: MatDialog,private api :ApiService) { }

  ngOnInit(): void {
    this.loadDep()
  }

  openDialog() {
    this.dialog.open(DialogDataExampleDialog);
  }

  loadDep(){
    this.api.getDepartamento().subscribe((dep:any)=>{
      this.departamentos = dep
      console.log(this.departamentos);
      
    })
  }
}

@Component({
  selector: 'dialogCrearUser',
  templateUrl: 'dialogCrearUser.html',
  standalone: true,
  imports: [MatDialogModule, NgIf],
})
export class DialogDataExampleDialog {
  constructor(@Inject(MAT_DIALOG_DATA) public data: any) { }
}
