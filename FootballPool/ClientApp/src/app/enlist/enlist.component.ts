import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ExternalData } from '../external-data';
import { FootballService } from '../football.service';
import { SimpleTeam } from '../structure';

@Component({
  selector: 'app-enlist',
  templateUrl: './enlist.component.html',
  styleUrls: ['./enlist.component.scss']
})
export class EnlistComponent implements OnInit {
  public enlistForm = new FormGroup({ 
    userName: new FormControl('', [Validators.required]), 
    firstName: new FormControl('', [Validators.required]),
    lastName: new FormControl('', [Validators.required]),
    address: new FormControl('', [Validators.required]), 
    city: new FormControl('', [Validators.required]), 
    state: new FormControl('', [Validators.required]),
    zipCode: new FormControl('', [Validators.required]), 
    cellPhone: new FormControl('', [Validators.required]),
    emailAddress: new FormControl('', [Validators.required]), 
    martialStatus: new FormControl('', [Validators.required]), 
    numberOfKids: new FormControl('', [Validators.required]), 
    otherFamily: new FormControl(''), 
    occupation: new FormControl(''), 
    age: new FormControl('', [Validators.required]), 
    favoriteTeam: new FormControl('', [Validators.required]),
    birthPlace: new FormControl('', [Validators.required]), 
    highSchool: new FormControl(''),
    college: new FormControl(''),
    brushWithGreatness: new FormControl(''), 
    interestingTidbits: new FormControl(''), 
    twitter: new FormControl(''), 
    instagram: new FormControl(''), 
    comments: new FormControl('') 
  });
  public states = ExternalData.states; 
  public teams: SimpleTeam[] = []; 

  constructor(private _football: FootballService) { 
    _football.GetSimpleTeams().subscribe(result => { 
      console.log(result); 
      this.teams = result; 
    })
  }

  ngOnInit(): void {
  }

}
