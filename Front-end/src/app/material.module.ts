import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { RouterModule } from '@angular/router';
import { MatSelectModule } from '@angular/material/select';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';
import { MatIconModule } from '@angular/material/icon';
import { MatDialogModule } from '@angular/material/dialog';

@NgModule({
  imports: [
    FormsModule,
    MatCardModule,
    MatSelectModule,
    MatButtonModule,
    MatTableModule,
    MatIconModule, MatDialogModule
  ],
  exports: [
    CommonModule,
    FormsModule,
    RouterModule,
    MatCardModule,
    MatSelectModule,
    MatButtonModule,
    MatTableModule,
    MatIconModule, MatDialogModule
  ]
})
export class MaterialModule { }
