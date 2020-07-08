import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './modules/app-routing.module';
import { AppComponent } from './components/app/app.component';
import { LoginComponent } from './components/login/login.component';
import { HomeComponent } from './components/home/home.component';
import { CreateDriverComponent } from './components/create-driver/create-driver.component';
import { UpdateDriverComponent } from './components/update-driver/update-driver.component';
import { RemoveDriverComponent } from './components/remove-driver/remove-driver.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeComponent,
    CreateDriverComponent,
    UpdateDriverComponent,
    RemoveDriverComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
