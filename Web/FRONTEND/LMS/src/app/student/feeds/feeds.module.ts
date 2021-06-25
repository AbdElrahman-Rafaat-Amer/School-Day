import { FeedsRoutingModule } from './feeds-routing.module';
import { LayoutComponent } from './layout.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PostComponent } from './post/post.component';
import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';



@NgModule({
  declarations: [
    LayoutComponent,
    PostComponent,
    
  ],
  imports: [
    CommonModule,
    FeedsRoutingModule,
    //BrowserModule,
    FormsModule,
    ReactiveFormsModule
    
  ]
})
export class FeedsModule { }
