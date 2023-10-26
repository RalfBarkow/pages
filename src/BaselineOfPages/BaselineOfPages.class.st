Class {
	#name : #BaselineOfPages,
	#superclass : #BaselineOf,
	#category : #BaselineOfPages
}

{ #category : #baseline }
BaselineOfPages >> baseline: spec [
	<baseline>
		^ spec for: #common do: [
			spec package: 'Pages'
		]
]
