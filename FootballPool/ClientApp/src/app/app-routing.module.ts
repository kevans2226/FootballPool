import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EnlistComponent } from './enlist/enlist.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
  {path: 'Login', component: LoginComponent},
  {path: 'Enlist', component: EnlistComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
